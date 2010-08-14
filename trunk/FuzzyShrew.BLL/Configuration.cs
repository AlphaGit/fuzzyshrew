using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using FuzzyShrew.Model;
using System.Reflection;
using System.IO;

namespace FuzzyShrew.BLL
{
    public class Configuration: ICloneable
    {
        #region Singleton
        private static Configuration _instance;
        public static Configuration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Configuration();
                return _instance;
            }
        } 
        #endregion

        #region Properties
        public string PluginPath { get; set; }
        public string ConfigurationFile { get; set; } 
        #endregion

        public Configuration()
	    {
            SetDefaultSettings();

            TryLoadSettings(this.ConfigurationFile);
	    }

        private void TryLoadSettings(string fileName)
        {
            try
            {
                Load(fileName);
            }
            catch (Exception ex)
            { 
                //TODO log
            }
        }

        private void SetDefaultSettings()
        {
            PluginPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "plugins");
            ConfigurationFile = "config.xml";
        }

        #region Active Record
        public void Save(string fileName)
        {
            var writer = XmlWriter.Create(fileName,
                new XmlWriterSettings()
                {
                    CloseOutput = true,
                    Encoding = Encoding.UTF8,
                    Indent = true,
                    IndentChars = "\t",
                    OmitXmlDeclaration = true
                });

            XmlSerializer x = new XmlSerializer(this.GetType());
            x.Serialize(writer, this);
        }
        public static void Load(string fileName)
        {
            var reader = XmlReader.Create(fileName,
                new XmlReaderSettings()
                {
                    CloseInput = true
                });

            XmlSerializer x = new XmlSerializer(typeof(Session));
            _instance = (Configuration)x.Deserialize(reader);
        } 
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            var config = new Configuration();
            config.PluginPath = this.PluginPath;

            return config;
        }

        #endregion
    }
}
