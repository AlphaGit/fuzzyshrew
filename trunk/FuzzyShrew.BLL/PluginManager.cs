using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin.Formats;
using FuzzyShrew.Model.Plugin;

namespace FuzzyShrew.BLL
{
    public class PluginManager
    {
        public static List<ExportFormatBase> LoadFormatPlugins()
        {
            //TODO get folder from config
            var plugins = PluginLoader.LoadPluginFolder("C:\\", PluginType.ExportFormatPlugin);
            return plugins.Select(p => (ExportFormatBase)p).ToList();
        }
    }
}
