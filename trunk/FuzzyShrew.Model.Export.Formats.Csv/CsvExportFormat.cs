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
        public CsvExportFormat(ExportMediaBase exportMedia): base(exportMedia)
        { }

        public override string Name
        {
            get { return "CSV"; }
            set { } 
        }

        public override string Author 
        {
            get { return "Alpha"; }
            set { } 
        }

        public override string Description 
        {
            get { return "Comma Separated Values"; }
            set { } 
        }

        public override bool IsPluginConfigurationValid
        {
            get { return true; }
            set { }
        }

        protected override string FormatResults(List<RequestResponseSnapshot> results)
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
    }
}
