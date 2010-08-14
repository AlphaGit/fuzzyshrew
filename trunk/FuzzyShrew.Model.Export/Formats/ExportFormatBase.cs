using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin;
using FuzzyShrew.Model.Plugin.Media;

namespace FuzzyShrew.Model.Plugin.Formats
{
    public abstract class ExportFormatBase: PluginBase
    {
        public ExportFormatBase(ExportMediaBase exportMedia)
        {
            ExportMedia = exportMedia;
        }

        public ExportMediaBase ExportMedia { get; set; }

        protected abstract string FormatResults(List<RequestResponseSnapshot> results);

        public void Export(List<RequestResponseSnapshot> results)
        {
            var formattedResults = FormatResults(results);

            ExportMedia.Export(formattedResults);
        }
    }
}
