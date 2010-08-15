using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;
using System.IO;

// code based on http://www.michael-clarke-blog.com/2008/04/05/c-dynamic-class-loading/
// changes based on http://social.msdn.microsoft.com/Forums/en-US/netfxbcl/thread/fa4f16e2-2a3c-4c21-a166-ff8b07e37971
namespace FuzzyShrew.Model.Plugin
{
    public class PluginLoader
    {
        private static List<PluginBase> LoadPlugins(string fileName, Type[] allowedTypes)
        {
            var plugins = new List<PluginBase>();

            try
            {
                Assembly assembly = Assembly.LoadFrom(fileName);
                foreach (Type type in assembly.GetTypes())
                    foreach (var allowedType in allowedTypes)
                        if (allowedType.IsAssignableFrom(type))
                            plugins.Add((PluginBase)Activator.CreateInstance(type));

            }
            catch (BadImageFormatException ex)
            {
                //TODO log ex
                //we do nothing, is just a incorrect file that could not be loaded as an assembly
            }
            catch (FileNotFoundException ex)
            {
                //TODO log ex
                //we do nothing, just go on
            }
            catch (Exception ex)
            {
                //TODO log ex
                throw;
            }

            return plugins;
        }

        public static List<PluginBase> LoadPlugins(string fileName)
        {
            return LoadPlugins(fileName, PluginType.AllExport);
        }

        public static List<PluginBase> LoadPlugins(string fileName, PluginType pluginType)
        {
            return LoadPlugins(fileName, pluginType.GetTypes());
        }

        public static List<PluginBase> LoadPluginFolder(string path)
        {
            return LoadPluginFolder(path, PluginType.AllExport);
        }

        public static List<PluginBase> LoadPluginFolder(string path, PluginType pluginType)
        {
            var plugins = new List<PluginBase>();

            try
            {
                var files = GetPluginFiles(path);
                foreach (var file in files)
                    plugins.AddRange(LoadPlugins(file, pluginType));
            }
            catch (DirectoryNotFoundException ex)
            {
                //TODO  log
            }

            return plugins;
        }

        public static PluginBase SearchAndLoadPlugin(string path, string className)
        {
            var files = GetPluginFiles(path);
            foreach (var file in files)
            {
                var plugin = LoadSpecificClass(file, className);
                if (plugin != null)
                    return (PluginBase)plugin;
            }

            return null;
        }

        private static object LoadSpecificClass(string fileName, string className)
        {
            Assembly assembly = Assembly.LoadFrom(fileName);
            foreach (Type type in assembly.GetTypes())
                if (type.FullName == className)
                    return Activator.CreateInstance(type);

            return null;
        }

        private static string[] GetPluginFiles(string folderPath)
        {
            return Directory.EnumerateFiles(folderPath, "*.dll", SearchOption.AllDirectories).ToArray();
        }
    }
}