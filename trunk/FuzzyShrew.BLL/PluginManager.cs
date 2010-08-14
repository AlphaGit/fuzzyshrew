using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin.Formats;
using FuzzyShrew.Model.Plugin;
using FuzzyShrew.Model.Plugin.Media;

namespace FuzzyShrew.BLL
{
    public class PluginManager
    {
        public static List<ExportFormatBase> LoadFormatPlugins()
        {
            var plugins = PluginLoader.LoadPluginFolder(Configuration.Instance.PluginPath, PluginType.ExportFormatPlugin);
            return plugins.Select(p => (ExportFormatBase)p).ToList();
        }

        public static List<ExportMediaBase> LoadMediaPlugins()
        {
            var plugins = PluginLoader.LoadPluginFolder(Configuration.Instance.PluginPath, PluginType.ExportMediaPlugin);
            return plugins.Select(p => (ExportMediaBase)p).ToList();
        }
    }
}
