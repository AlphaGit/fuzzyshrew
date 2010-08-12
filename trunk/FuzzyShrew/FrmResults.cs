using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyShrew.BLL;
using FuzzyShrew.Model;

namespace FuzzyShrew
{
    public partial class FrmResults : Form
    {
        private List<RequestResponseSnapshot> _snapshots;
        private RequestProcessor _processor;
        public RequestProcessor Processor 
        { 
            get
            {
                return _processor;
            }
            set
            {
                _processor = value;
                _processor.ProgressChanged += new ProgressChangedEventHandler(_processor_ProgressChanged);
                _processor.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_processor_RunWorkerCompleted);

                SetColumnsFromSession(value.SessionConfiguration);
            }
        }

        private void SetColumnsFromSession(Session session)
        {
            dgResults.ColumnCount = session.Variables.Count + session.ResultExpressions.Count;
            int i = 0;
            while (i < session.Variables.Count)
            {
                dgResults.Columns[i].HeaderText = session.Variables[i].VariableID;
                dgResults.Columns[i].Name = session.Variables[i].VariableID;
                i++;
            }

            int j = 0;
            while (j < session.ResultExpressions.Count)
            {
                dgResults.Columns[i + j].HeaderText = session.ResultExpressions[j].Name;
                dgResults.Columns[i + j].Name = session.ResultExpressions[j].Name;
                j++;
            }
        }

        private void _processor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCancel.Enabled = false;
        }

        private void _processor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var snapshot = (RequestResponseSnapshot)e.UserState;
            RefreshData(snapshot);
            _snapshots.Add(snapshot);
        }

        private void RefreshData(RequestResponseSnapshot snapshot)
        {
            DataGridViewRow row = dgResults.Rows[dgResults.Rows.Add()];

            if (snapshot.VariablesState != null)
                for (int i = 0; i < snapshot.VariablesState.Count; i++)
                    row.Cells[snapshot.VariablesState[i].VariableID].Value = snapshot.VariablesState[i].Value;

            if (snapshot.ResultsSnapshot != null)
                for (int i = 0; i < snapshot.ResultsSnapshot.Count; i++)
                    row.Cells[snapshot.ResultsSnapshot[i].Name].Value = snapshot.ResultsSnapshot[i].IsPresent;
        }

        public FrmResults(Session session)
        {
            InitializeComponent();
            Processor = new RequestProcessor(session);
            _snapshots = new List<RequestResponseSnapshot>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _processor.CancelAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var snapshot = _snapshots[e.RowIndex];

            //TODO: snapshot.ToString();
            var requestText = snapshot.Request.Method + ":" + snapshot.Request.RequestUri;

            MessageBox.Show(requestText);
        }
    }
}
