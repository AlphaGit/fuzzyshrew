using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.Export
{
    public class ResultExporter
    {
        public static void ExportResults(List<RequestResponseSnapshot> results, ExportConfiguration exportConfiguration)
        {
            var formatter = exportConfiguration.ExportFormat;
            var exporter = exportConfiguration.ExportMedia;

            //TODO implement methods to report progress
            var formattedResults = formatter.FormatResults(results);
            exporter.Export(formattedResults);
        }
    }
}
