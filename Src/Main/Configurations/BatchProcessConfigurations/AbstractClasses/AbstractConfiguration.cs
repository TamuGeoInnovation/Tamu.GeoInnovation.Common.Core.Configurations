using System;
using System.Xml.Serialization;

namespace USC.GISResearchLab.Common.Core.Configurations
{

    [Serializable]
    [XmlInclude(typeof(DefaultOptimizationConfiguration))]
    [XmlInclude(typeof(DefaultServerConfiguration))]
    [XmlInclude(typeof(DefaultLoggingConfiguration))]

    public abstract class AbstractConfiguration
    {
        #region Properties

        public Version CoreVersion { get; set; }
        public Version InterfaceVersion { get; set; }

        public string ConfigurationFilePath { get; set; }


        [XmlIgnore]
        public string EncryptionKey { get; set; }

        public AbstractOptimizationConfiguration OptimizationConfiguration { get; set; }
        public AbstractServerConfiguration ServerConfiguration { get; set; }
        public AbstractLoggingConfiguration LoggingConfiguration { get; set; }

        #endregion

        public AbstractConfiguration()
        {

        }

        public abstract void SetDefaults();

        public abstract void SaveToFile(string configFilePath);
    }
}
