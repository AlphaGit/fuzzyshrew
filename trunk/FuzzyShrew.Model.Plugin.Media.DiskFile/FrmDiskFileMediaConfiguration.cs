using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuzzyShrew.Model.Plugin.Media.DiskFile
{
    public partial class FrmDiskFileMediaConfiguration : MediaConfigurationFormBase
    {
        public FrmDiskFileMediaConfiguration(DiskFileExportMedia config): base(config)
        {
            InitializeComponent();

            txtFileName.Text = config.FileName;
            sfExportTo.FileName = config.FileName;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseForFile();
        }

        private void BrowseForFile()
        {
            if (sfExportTo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((DiskFileExportMedia)MediaToConfigure).FileName = sfExportTo.FileName;
                txtFileName.Text = sfExportTo.FileName;
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            ((DiskFileExportMedia)MediaToConfigure).FileName = txtFileName.Text;
        }
    }
}
