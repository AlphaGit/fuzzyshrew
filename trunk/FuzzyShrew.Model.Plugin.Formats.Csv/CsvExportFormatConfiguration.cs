using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.Plugin.Formats.Csv
{
    public class CsvExportFormatConfiguration
    {
        public List<CsvField> Fields { get; set; }
        public bool ShowTitles { get; set; }
        public bool UseQuotationMarksForAll { get; set; }

        public CsvExportFormatConfiguration()
        {
            // load default config
            CsvField field = new CsvField()
            {
                ClassType = typeof(RequestResponseSnapshot),
                FieldName = "RequestResponseSnapshot",
                ShowField = false
            };

            Fields = new List<CsvField>() { field };
            ShowTitles = true;
            UseQuotationMarksForAll = false;
        }

        public CsvExportFormatConfiguration Clone()
        {
            return new CsvExportFormatConfiguration()
            {
                Fields = this.Fields.Select(f => f.Clone()).ToList(),
                ShowTitles = this.ShowTitles,
                UseQuotationMarksForAll = this.UseQuotationMarksForAll
            };
        }
    }
}
