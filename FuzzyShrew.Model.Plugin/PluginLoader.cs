using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

// code based on http://www.michael-clarke-blog.com/2008/04/05/c-dynamic-class-loading/
namespace FuzzyShrew.Model.Plugin
{
    public class PluginLoader
    {
        private static List<PluginBase> LoadPlugins(string fileName, string[] allowedTypes)
        {
            var plugins = new List<PluginBase>();

            Assembly assembly = Assembly.LoadFile(fileName);
            foreach (Type type in assembly.GetTypes())
                foreach (var allowedType in allowedTypes)
                    if (type.GetInterface(allowedType) != null)
                        plugins.Add((PluginBase)Activator.CreateInstance(type));

            return plugins;
        }

        public static List<PluginBase> LoadPlugins(string fileName)
        {
            return LoadPlugins(fileName, PluginType.AllExport);
        }

        public static List<PluginBase> LoadPlugins(string fileName, PluginType pluginType)
        {
            return LoadPlugins(fileName, pluginType.GetTypeNames());
        }

        public static List<PluginBase> LoadPluginFolder(string path)
        {
            return LoadPluginFolder(path, PluginType.AllExport);
        }

        public static List<PluginBase> LoadPluginFolder(string path, PluginType pluginType)
        {
            //TODO search for files in path
            var fileName = string.Empty;
            var plugins = new List<PluginBase>();

            plugins.AddRange(LoadPlugins(fileName, pluginType));

            return plugins;
        }
    }
}