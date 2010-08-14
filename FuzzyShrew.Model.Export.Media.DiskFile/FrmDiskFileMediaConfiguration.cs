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
    public partial class FrmDiskFileMediaConfiguration : Form
    {
        public string FileName { get; set; }

        public FrmDiskFileMediaConfiguration()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseForFile();
        }

        private void BrowseForFile()
        {
            if (sfExportTo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                FileName = sfExportTo.FileName;
                txtFileName.Text = FileName;
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            FileName = txtFileName.Text;
        }
    }
}
