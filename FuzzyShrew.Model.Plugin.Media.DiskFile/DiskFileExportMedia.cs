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

        public override bool IsPluginConfigurationValid()
        {
            return !string.IsNullOrEmpty(FileName);
        }

        public override string Author { get {  return "Alpha"; } }
        public override string Description { get { return "This plugin will allow you to export your results to a file in disk."; } }
        public override string Name { get { return "Disk file"; } }

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
        }

        public override void ShowConfigurationForm(System.Windows.Forms.IWin32Window owner)
        {
            using (var configurationForm = new FrmDiskFileMediaConfiguration(this.Clone()))
            {
                if (configurationForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    GetValuesFrom((DiskFileExportMedia)configurationForm.MediaToConfigure);
            }
        }

        private void GetValuesFrom(DiskFileExportMedia config)
        {
            FileName = config.FileName;
        }

        private DiskFileExportMedia Clone()
        {
            return new DiskFileExportMedia()
            {
                FileName = this.FileName
            };
        }
    }
}
