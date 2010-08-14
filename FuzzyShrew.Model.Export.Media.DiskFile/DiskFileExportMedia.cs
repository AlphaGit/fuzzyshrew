using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FuzzyShrew.Model.Plugin.Media.DiskFile
{
    public class DiskFileExportMedia: ExportMediaBase
    {
        public string FileName { get; set; }

        public override void Export(string results)
        {
            using (var tw = new StreamWriter(FileName))
            {
                tw.Write(results);
                tw.Flush();
                tw.Close();
            }
        }

        public override void ConfigureOptions()
        {
            var configurationForm = new FrmDiskFileMediaConfiguration();
            if (configurationForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                FileName = configurationForm.FileName;
        }
    }
}
