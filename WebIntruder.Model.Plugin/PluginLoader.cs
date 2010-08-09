using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

// code based on http://www.michael-clarke-blog.com/2008/04/05/c-dynamic-class-loading/
namespace WebIntruder.Model.Plugin
{
    public class PluginLoader
    {
        public static PluginBase LoadPlugin(string fileName)
        {
            Assembly assembly = Assembly.LoadFile(fileName);
            foreach (Type type in assembly.GetTypes())
                if (type.GetInterface("PluginBase") != null)
                    return (PluginBase)Activator.CreateInstance(type);

            return null;
        }
    }
}