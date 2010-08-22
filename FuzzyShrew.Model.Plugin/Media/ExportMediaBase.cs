using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.Plugin.Media
{
    public abstract class ExportMediaBase: PluginBase
    {
        public abstract void Export(string results);
        public abstract void ConfigureOptions();
    }
}
