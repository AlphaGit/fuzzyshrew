using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using WebIntruder.Model;
using System.Net;
using System.IO;

namespace WebIntruder.BLL
{
    public class RequestProcessor: BackgroundWorker
    {
        private RequestProcessor()
        {
            this.WorkerSupportsCancellation = true;
            this.WorkerReportsProgress = true;
            Snapshots = new List<RequestResponseSnapshot>();
        }
        public RequestProcessor(Session session): this()
        {
            SessionConfiguration = session;
        }

        public List<RequestResponseSnapshot> Snapshots { get; set; }
        public Session SessionConfiguration { get; set; }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            base.OnDoWork(e);
            if (SessionConfiguration == null) return;

            VariableController varController = new VariableController(SessionConfiguration.Variables);

            while (!varController.HasReachedEnd())
            {
                if (this.CancellationPending) return;

                RequestResponseSnapshot snapshot = new RequestResponseSnapshot();

                try
                {
                    var url = GetRequestUrl();
                    url = SetGetParameters(url);
                    var request = new WebRequestHelper(SessionConfiguration, url);
                    snapshot.Request = request.Request;

                    request.SetHeaders();
                    snapshot.VariablesState = CreateVariablesSnapshot(SessionConfiguration.Variables);

                    request.SendBody();
                    var response = request.GetResponse();
                    snapshot.Response = response;
                    snapshot.ResponseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    snapshot.ResultsSnapshot = GenerateResults(response, snapshot.ResponseString);
                }
                catch (WebException wex)
                {
                    snapshot.ResponseString = "<<Error: " + wex.Message + ">>";
                }

                ReportProgress(varController.GetCurrentCombination() * 100 / varController.GetTotalCombinations(), snapshot);

                varController.AdvanceOneCombination();
            }
        }

        private List<ResultExpressionSnapshot> GenerateResults(WebResponse response, string responseString)
        {
            List<ResultExpressionSnapshot> resultSnapshotList = new List<ResultExpressionSnapshot>();
            SessionConfiguration.ResultExpressions.ForEach(r =>
                    resultSnapshotList.Add(new ResultExpressionSnapshot(r.Name, r.IsConditionMet(responseString)))
            );

            return resultSnapshotList;
        }
        private List<VariableSnapshot> CreateVariablesSnapshot(List<Variable> list)
        {
            List<VariableSnapshot> snapshotList = new List<VariableSnapshot>();
            list.ForEach(v => snapshotList.Add(v.GetSnapshot()));
            return snapshotList;
        }

        private string GetRequestUrl()
        {
            var url = SessionConfiguration.Url;
            if (!url.StartsWith("http")) url = "http://" + url;
            return SessionConfiguration.ApplyVariables(url);
        }
        private string SetGetParameters(string url)
        {
            var parameters = SessionConfiguration.GetParameters.Select(p =>
                SessionConfiguration.ApplyVariables(p.Name) + "=" + SessionConfiguration.ApplyVariables(p.Value));
            if (parameters.Count() > 0) url += "?" + string.Join("&", parameters);

            return url;
        }
    }
}
