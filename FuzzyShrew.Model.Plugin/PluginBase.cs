using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.Plugin
{
    public abstract class PluginBase
    {
        public abstract string Name { get; }
        public abstract string Author { get; }
        public abstract string Description { get; }
        public abstract bool IsPluginConfigurationValid();
    }
}
