using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyShrew.BLL;
using FuzzyShrew.Model.Plugin.Formats;
using FuzzyShrew.Model.Plugin.Media;
using FuzzyShrew.Model.Export;
using FuzzyShrew.Model.Plugin.Variables;

namespace FuzzyShrew
{
    public partial class FrmVariableTypeSelector : Form
    {
        private List<VariableBase> _variables;

        public VariableBase SelectedVariable { get; set; }

        public FrmVariableTypeSelector()
        {
            InitializeComponent();
        }

        private void FrmExportResults_Load(object sender, EventArgs e)
        {
            ReloadVariablePluginList();
        }

        private void ReloadVariablePluginList()
        {
            _variables = PluginManager.LoadVariablePlugins();
            RefreshVariablesCombo();
        }

        private void RefreshVariablesCombo()
        {
            cmbVariableTypes.DataSource = _variables;
            cmbVariableTypes.DisplayMember = "Name";
        }

        private void cmbExportFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectVariablePlugin();
            ShowDataForCurrentVariable();
        }

        private void SelectVariablePlugin()
        {
            SelectedVariable = (VariableBase)cmbVariableTypes.SelectedValue;
        }

        private void ShowDataForCurrentVariable()
        {
            var variable = SelectedVariable;
            lblVariableTypeAuthor.Text = variable.Author;
            lblVariableTypeDescription.Text = variable.Description;
        }

        private void btnConfigureVariableTypePlugin_Click(object sender, EventArgs e)
        {
            SelectedVariable.ShowConfigurationForm(this);
        }
    }
}
