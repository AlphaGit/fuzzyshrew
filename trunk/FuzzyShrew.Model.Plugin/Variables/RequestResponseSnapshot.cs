using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace FuzzyShrew.Model
{
    public class RequestResponseSnapshot
    {
        public WebRequest Request { get; set; }
        public WebResponse Response { get; set; }
        public List<VariableSnapshot> VariablesState { get; set; }
        public List<ResultExpressionSnapshot> ResultsSnapshot { get; set; }
        public string RequestString { get; set; }
        public string ResponseString { get; set; }

        public RequestResponseSnapshot(WebRequest request, WebResponse response, List<VariableSnapshot> variablesState, List<ResultExpressionSnapshot> resultsSnapshot, string requestString, string responseString)
        {
            Request = request;
            Response = response;
            VariablesState = variablesState;
            ResultsSnapshot = resultsSnapshot;
            RequestString = requestString;
            ResponseString = responseString;
        }

        public RequestResponseSnapshot()
        {

        }
    }
}
