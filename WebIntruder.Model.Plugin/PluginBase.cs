using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebIntruder.Model.Plugin
{
    public abstract class PluginBase
    {
        public abstract string Name { get; set; }
        public abstract string Author { get; set; }
        public abstract string Description { get; set; }
    }
}
