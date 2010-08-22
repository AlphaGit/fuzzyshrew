using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.Plugin.Formats.Csv
{
    public class CsvExportFormatConfiguration
    {
        public CsvField FieldTreeRoot { get; set; }
        public bool ShowTitles { get; set; }
        public bool UseQuotationMarksForAll { get; set; }

        public CsvExportFormatConfiguration()
        {
            // load default config
            FieldTreeRoot = new CsvField()
            {
                ClassType = typeof(RequestResponseSnapshot),
                FieldName = "RequestResponseSnapshot",
                ShowField = false
            };

            ShowTitles = true;
            UseQuotationMarksForAll = false;
        }

        public CsvExportFormatConfiguration Clone()
        {
            return new CsvExportFormatConfiguration()
            {
                FieldTreeRoot = this.FieldTreeRoot.Clone(),
                ShowTitles = this.ShowTitles,
                UseQuotationMarksForAll = this.UseQuotationMarksForAll
            };
        }
    }
}
