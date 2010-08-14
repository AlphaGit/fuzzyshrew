using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyShrew.BLL;

namespace FuzzyShrew
{
    public partial class FrmExportResults : Form
    {
        private List<ExportFormatBase> _formats;

        public FrmExportResults()
        {
            InitializeComponent();
        }

        private void FrmExportResults_Load(object sender, EventArgs e)
        {
            ReloadExportFormatPluginList();
            ReloadExportMediaPluginList();
        }

        private void ReloadExportMediaPluginList()
        {
            var plugins = PluginManager.LoadFormatPlugins();
            //cmbExportFormat.DataSource = plugins;
        }

        private void ReloadExportFormatPluginList()
        {
            throw new NotImplementedException();
        }
    }
}
