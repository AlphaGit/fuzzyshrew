using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebIntruder.Model.Plugin;
using WebIntruder.Model.Plugin.Media;

namespace WebIntruder.Model.Plugin.Formats
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
