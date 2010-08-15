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
using FuzzyShrew.Model;

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

        private void ReloadExportFormatPluginList()
        {
            _formats = PluginManager.LoadFormatPlugins();
            RefreshFormatCombo();
        }

        private void RefreshFormatCombo()
        {
            cmbExportFormat.DataSource = _formats;
            cmbExportFormat.DisplayMember = "Name";
        }

        private void ReloadExportMediaPluginList()
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

        private void lnkReloadFormatPluginList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReloadExportFormatPluginList();
        }

        private void lnkReloadMediaPlugins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReloadExportMediaPluginList();
        }

        private void btnConfigureExportFormatPlugin_Click(object sender, EventArgs e)
        {
            Configuration.ExportFormat.ShowConfigurationForm(this);
        }

        private void btnConfigureExporMedia_Click(object sender, EventArgs e)
        {
            Configuration.ExportMedia.ShowConfigurationForm(this);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!Configuration.ExportMedia.IsPluginConfigurationValid()
                || !Configuration.ExportFormat.IsPluginConfigurationValid())
            {
                MessageBox.Show("Some of the plugins are not yet configured correctly. Please review their configuration.");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbExportMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectMediaPlugin();
            ShowDataForCurrentMedia();
        }

        private void ShowDataForCurrentMedia()
        {
            var media = Configuration.ExportMedia;
            lblExportMediaAuthor.Text = media.Author;
            lblExportMediaDescription.Text = media.Description;            
        }

        private void SelectMediaPlugin()
        {
            Configuration.ExportMedia = (ExportMediaBase)cmbExportMedia.SelectedValue;
        }
    }
}
