using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public static string[] GetTypeNames(this PluginType type)
        {
            switch (type)
            {
                case PluginType.ExportFormatPlugin:
                    return new string[] { "ExportFormatBase" };
                case PluginType.ExportMediaPlugin:
                    return new string[] { "ExportMediaBase" };
                case PluginType.AllExport:
                    return new string[] { "ExportFormatBase", "ExportMediaBase" };
                default:
                    throw new ArgumentException("Invalid value for plugin type", "type");
            }
        }
    }
}
