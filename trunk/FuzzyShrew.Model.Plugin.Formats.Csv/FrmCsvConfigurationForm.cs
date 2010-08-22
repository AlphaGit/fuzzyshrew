using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyShrew.Model.Plugin.Formats;

namespace FuzzyShrew.Model.Plugin.Formats.Csv
{
    public partial class FrmCsvConfigurationForm : FormatConfigurationFormBase
    {
        private CsvExportFormat _format;

        public FrmCsvConfigurationForm(CsvExportFormat format)
            : base(format)
        {
            InitializeComponent();
            _format = (CsvExportFormat)format;

            SetInitialValues(_format.Configuration);
        }

        private void SetInitialValues(CsvExportFormatConfiguration configuration)
        {
            chkShowTitles.Checked = configuration.ShowTitles;
            chkUseQuotationMarksForAll.Checked = configuration.UseQuotationMarksForAll;
            RenegerateFieldsTree(configuration.Fields);
        }

        private void RenegerateFieldsTree(List<CsvField> list)
        {
            //TODO 
            throw new NotImplementedException();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void chkShowTitles_CheckedChanged(object sender, EventArgs e)
        {
            _format.Configuration.ShowTitles = chkShowTitles.Checked;
        }

        private void chkUseQuotationMarksForAll_CheckedChanged(object sender, EventArgs e)
        {
            _format.Configuration.UseQuotationMarksForAll = chkUseQuotationMarksForAll.Checked;
        }
    }
}
