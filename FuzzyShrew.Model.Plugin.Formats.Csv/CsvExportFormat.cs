using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin;
using FuzzyShrew.Model.Plugin.Media;

namespace FuzzyShrew.Model.Plugin.Formats.Csv
{
    public class CsvExportFormat: ExportFormatBase
    {
        public CsvExportFormatConfiguration Configuration { get; set; }

        public override string Name
        {
            get { return "CSV"; }
        }

        public override string Author 
        {
            get { return "Alpha"; }
        }

        public override string Description 
        {
            get { return "Comma Separated Values"; }
        }

        public override bool IsPluginConfigurationValid()
        {
            return true;
        }

        public override string FormatResults(List<RequestResponseSnapshot> results)
        {
            var formatted = FormatHeader(results.FirstOrDefault()) + Environment.NewLine;

            foreach (var r in results)
                formatted += FormatResult(r) + Environment.NewLine;

            return formatted;
        }

        protected string FormatHeader(RequestResponseSnapshot result)
        {
            if (result == null) return string.Empty;

            var formatted = string.Empty;
            formatted += "RequestString,ResponseCode,";
            
            foreach (var v in result.VariablesState)
                formatted += "\"" + v.VariableID + "\",";

            foreach (var e in result.ResultsSnapshot)
                formatted += "\"" + e.Name + "\",";

            return formatted.Remove(formatted.Length - 1);
        }

        private string FormatResult(RequestResponseSnapshot result)
        {
 	        var formatted = "\"" + result.RequestString + "\"," + result.ResponseString + "\",";

            foreach (var v in result.VariablesState)
                formatted += "\"" + v.Value + "\",";

            foreach (var r in result.ResultsSnapshot)
                formatted += "\"" + r.IsPresent.ToString() + "\"";

            return formatted.Remove(formatted.Length - 1);
        }

        public override void ShowConfigurationForm(System.Windows.Forms.IWin32Window owner)
        {
            using (var config = new FrmCsvConfigurationForm(this.Clone()))
            {
                if (config.DialogResult == System.Windows.Forms.DialogResult.OK)
                    GetValuesFrom((CsvExportFormat) config.FormatToConfigure);
            }
        }

        private void GetValuesFrom(CsvExportFormat csvConfig)
        {
            //TODO fill current object with values from csvConfig
        }

        private CsvExportFormat Clone()
        {
            return new CsvExportFormat()
            {
                Configuration = this.Configuration.Clone()
            };
        }

        public CsvExportFormat()
        {
            Configuration = new CsvExportFormatConfiguration();
        }
    }
}
