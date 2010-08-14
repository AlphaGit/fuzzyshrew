using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.Plugin
{
    public abstract class PluginBase
    {
        public abstract string Name { get; set; }
        public abstract string Author { get; set; }
        public abstract string Description { get; set; }
        public abstract bool IsPluginConfigurationValid { get; set; }
    }
}
