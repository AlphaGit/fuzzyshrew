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
        public abstract string FormatResults(List<RequestResponseSnapshot> results);
    }
}
