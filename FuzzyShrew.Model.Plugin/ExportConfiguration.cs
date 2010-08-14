using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin.Media;
using FuzzyShrew.Model.Plugin.Formats;

namespace FuzzyShrew.Model.Export
{
    public class ExportConfiguration
    {
        public ExportMediaBase ExportMedia { get; set; }
        public ExportFormatBase ExportFormat { get; set; }
    }
}
