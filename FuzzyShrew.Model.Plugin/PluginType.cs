using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin.Formats;
using FuzzyShrew.Model.Plugin.Media;

namespace FuzzyShrew.Model.Plugin
{
    public enum PluginType
    {
        ExportFormatPlugin,
        ExportMediaPlugin,
        AllExport
    }

    public static class PluginTypeExtensionMethods
    {
        public static Type[] GetTypes(this PluginType type)
        {
            switch (type)
            {
                case PluginType.ExportFormatPlugin:
                    return new Type[] { typeof(ExportFormatBase) };
                case PluginType.ExportMediaPlugin:
                    return new Type[] { typeof(ExportMediaBase) };
                case PluginType.AllExport:
                    return new Type[] { typeof(ExportFormatBase), typeof(ExportMediaBase) };
                default:
                    throw new ArgumentException("Invalid value for plugin type", "type");
            }
        }
    }
}
