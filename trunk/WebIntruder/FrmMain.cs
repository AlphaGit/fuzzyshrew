using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebIntruder.Model;
using WebIntruder.Model.VariableSources;

namespace WebIntruder
{
    public partial class FrmMain : Form
    {
        private BindingList<HTTPHeader> _headers;
        private BindingList<Variable> _variables;
        private BindingList<Parameter> _getParameters;
        private BindingList<Parameter> _postParameters;
        private BindingList<ResultExpression> _resultExpressions;
        private string _url;
        private string _method;

        public FrmMain()
        {
            InitializeComponent();
            CustomInitalizeComponent();
            InitalizeSimpleVariables();
            InitalizeLists();

            FillVariableTypesCombo();
        }

        private void InitalizeSimpleVariables()
        {
            _url = string.Empty;
            ddMethod.SelectedIndex = 0;
            _method = "GET";
        }

        private void FillVariableTypesCombo()
        {
            var variableTypeNames = new VariableSourceType().GetType().GetEnumNames();
            foreach (var type in variableTypeNames)
                colVariableVariableSource.Items.Add(type);
        }

        private void CustomInitalizeComponent()
        {
            dgHeaders.AutoGenerateColumns = false;
            dgGETParameters.AutoGenerateColumns = false;
            dgVariables.AutoGenerateColumns = false;
        }

        private void InitalizeLists()
        {
            _headers = new BindingList<HTTPHeader>();
            _variables = new BindingList<Variable>();
            _getParameters = new BindingList<Parameter>();
            _postParameters = new BindingList<Parameter>();
            _resultExpressions = new BindingList<ResultExpression>();
        }

        private void dgVariables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if configure button
            if (e.ColumnIndex == colVariableConfigure.Index)
            {
                var grid = (DataGridView)sender;
                if (e.RowIndex < 0) return;

                var variable = (Variable)grid.Rows[e.RowIndex].DataBoundItem;

                if (variable != null) variable.Source.ShowConfigurationForm(this);
            }
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            _url = txtURL.Text;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshHeadersDataSource();
            RefreshVariablesDataSource();
            RefreshGETParametersDataSource();
            RefreshResultExpressionsDataSource();
        }

        private void RefreshResultExpressionsDataSource()
        {
            dgResultExpressions.DataSource = _resultExpressions;
        }

        private void RefreshGETParametersDataSource()
        {
            dgGETParameters.DataSource = _getParameters;
        }

        private void RefreshVariablesDataSource()
        {
            dgVariables.DataSource = _variables;
        }

        private void RefreshHeadersDataSource()
        {
            dgHeaders.DataSource = _headers;
        }

        private void btnHeaderAdd_Click(object sender, EventArgs e)
        {
            _headers.Add(new HTTPHeader());
        }

        private void btnHeaderRemove_Click(object sender, EventArgs e)
        {
            var header = GetSelectedHeader();

            if (header != null)
                _headers.Remove(header);
        }

        private HTTPHeader GetSelectedHeader()
        {
            if (dgHeaders.SelectedRows.Count == 0) return null;
            return (HTTPHeader)dgHeaders.SelectedRows[0].DataBoundItem;
        }

        private void btnGETParameterAdd_Click(object sender, EventArgs e)
        {
            _getParameters.Add(new Parameter());
        }

        private void btnGETParameterRemove_Click(object sender, EventArgs e)
        {
            var parameter = GetSelectedGetParameter();
            if (parameter != null)
                _getParameters.Remove(parameter);
        }

        private Parameter GetSelectedGetParameter()
        {
            if (dgGETParameters.SelectedRows.Count == 0) return null;
            return (Parameter)dgGETParameters.SelectedRows[0].DataBoundItem;
        }

        private void btnVariableAdd_Click(object sender, EventArgs e)
        {
            _variables.Add(new Variable());
        }

        private void btnVariableRemove_Click(object sender, EventArgs e)
        {
            var variable = GetSelectedVariable();
            if (variable != null)
                _variables.Remove(variable);
        }

        private Variable GetSelectedVariable()
        {
            if (dgVariables.SelectedRows.Count == 0) return null;
            return (Variable)dgVariables.SelectedRows[0].DataBoundItem;
        }

        private void dgVariables_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // if we are on the variable source type column
            if (e.ColumnIndex == colVariableVariableSource.Index)
            {
                if (e.RowIndex < 0) return;

                var variable = (Variable)dgVariables.Rows[e.RowIndex].DataBoundItem;

                if (variable == null) return;

                variable.SetNewSource((string)dgVariables.CurrentCell.Value);
            }
        }

        private void btnExpressionAdd_Click(object sender, EventArgs e)
        {
            _resultExpressions.Add(new ResultExpression());
        }

        private ResultExpression GetSelectedResultExpression()
        {
            if (dgResultExpressions.SelectedRows.Count == 0) return null;
            return (ResultExpression)dgResultExpressions.SelectedRows[0].DataBoundItem;
        }

        private void btnExpressionRemove_Click(object sender, EventArgs e)
        {
            var resultExpression = GetSelectedResultExpression();
            if (resultExpression != null)
                _resultExpressions.Remove(resultExpression);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var session = GenerateSession();
            FrmResults results = new FrmResults(session);
            results.Processor.RunWorkerAsync();
            results.ShowDialog(this);
        }

        private void dgGETParameters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgHeaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgResultExpressions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            if (sdSaveConfig.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var session = GenerateSession();
                session.Save(sdSaveConfig.FileName);
            }
        }

        private Session GenerateSession()
        {
            return new Session(_headers.ToList(), _getParameters.ToList(), _postParameters.ToList(), _variables.ToList(), _resultExpressions.ToList(), _url, _method);
        }

        private void btnLoadConfiguration_Click(object sender, EventArgs e)
        {
            if (ofOpenConfig.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var session = Session.Load(ofOpenConfig.FileName);
                this._getParameters = new BindingList<Parameter>(session.GetParameters);
                this._headers = new BindingList<HTTPHeader>(session.Headers);
                this._resultExpressions = new BindingList<ResultExpression>(session.ResultExpressions);
                this._url = session.Url;
                this._variables = new BindingList<Variable>(session.Variables);

                RefreshGETParametersDataSource();
                RefreshHeadersDataSource();
                RefreshResultExpressionsDataSource();
                RefreshVariablesDataSource();
                txtURL.Text = _url;
                ddMethod.SelectedIndex = ddMethod.FindString(session.Method);
            }
        }

        private void btnPOSTParameterAdd_Click(object sender, EventArgs e)
        {
            _postParameters.Add(new Parameter());
        }

        private void btnPOSTParameterRemove_Click(object sender, EventArgs e)
        {
            var parameter = GetSelectedPostParameter();
            if (parameter != null)
                _postParameters.Remove(parameter);
        }

        private Parameter GetSelectedPostParameter()
        {
            if (dgPOSTParameters.SelectedRows.Count == 0) return null;
            return (Parameter)dgPOSTParameters.SelectedRows[0].DataBoundItem;
        }

        private void ddMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            _method = ddMethod.GetItemText(ddMethod.SelectedItem);
        }
    }
}
