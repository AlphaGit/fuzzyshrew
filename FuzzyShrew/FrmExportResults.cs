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

namespace FuzzyShrew
{
    public partial class FrmExportResults : Form
    {
        private List<ExportFormatBase> _formats;
        private List<ExportMediaBase> _medias;

        public ExportConfiguration Configuration { get; set; }

        public FrmExportResults()
        {
            InitializeComponent();
            Configuration = new ExportConfiguration();
        }

        private void FrmExportResults_Load(object sender, EventArgs e)
        {
            ReloadExportFormatPluginList();
            ReloadExportMediaPluginList();
        }

        private void ReloadExportMediaPluginList()
        {
            _formats = PluginManager.LoadFormatPlugins();
            RefreshFormatCombo();
        }

        private void RefreshFormatCombo()
        {
            cmbExportFormat.DataSource = _formats;
            cmbExportFormat.DisplayMember = "Name";
        }

        private void ReloadExportFormatPluginList()
        {
            _medias = PluginManager.LoadMediaPlugins();
            RefreshMediaCombo();
        }

        private void RefreshMediaCombo()
        {
            cmbExportMedia.DataSource = _medias;
            cmbExportMedia.DisplayMember = "Name";
        }

        private void cmbExportFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectFormatPlugin();
            ShowDataForCurrentFormat();
        }

        private void SelectFormatPlugin()
        {
            Configuration.ExportFormat = (ExportFormatBase)cmbExportFormat.SelectedValue;
        }

        private void ShowDataForCurrentFormat()
        {
            var format = Configuration.ExportFormat;
            lblExportFormatAuthor.Text = format.Author;
            lblExportFormatDescription.Text = format.Description;
        }
    }
}
