using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.Plugin.Media
{
    public abstract class ExportMediaBase
    {
        public string Name;
        public string Description;
        public string Author;

        public abstract void Export(string results);
        public abstract void ConfigureOptions();
    }
}
