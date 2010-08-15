using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin.Formats;
using FuzzyShrew.Model.Plugin.Media;
using FuzzyShrew.Model.Plugin.Variables;

namespace FuzzyShrew.Model.Plugin
{
    public enum PluginType
    {
        ExportFormatPlugin,
        ExportMediaPlugin,
        VariablePlugin,
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
                case PluginType.VariablePlugin:
                    return new Type[] { typeof(VariableBase) };
                case PluginType.AllExport:
                    return new Type[] { typeof(ExportFormatBase), typeof(ExportMediaBase) };
                default:
                    throw new ArgumentException("Invalid value for plugin type", "type");
            }
        }
    }
}
