using System;
using System.IO;
using System.Xml.Serialization;
using USC.GISResearchLab.Common.Utils.Files;
using System.Reflection;

namespace USC.GISResearchLab.Common.Core.Configurations
{
    [Serializable]
    public class DefaultConfiguration : AbstractConfiguration
    {
        #region Properties

        #endregion

        public DefaultConfiguration() : this(Assembly.GetExecutingAssembly().GetName().Version, Assembly.GetExecutingAssembly().GetName().Version) { }

        public DefaultConfiguration(Version coreVersion, Version interfaceVersion)
        {
            OptimizationConfiguration = new DefaultOptimizationConfiguration();
            ServerConfiguration = new DefaultServerConfiguration();
            LoggingConfiguration = new DefaultLoggingConfiguration();
            CoreVersion = coreVersion;
            InterfaceVersion = interfaceVersion;
        }

        public override void SetDefaults()
        {
            OptimizationConfiguration.SetDefaults();
            ServerConfiguration.SetDefaults();
            LoggingConfiguration.SetDefaults();
        }


        public static DefaultConfiguration LoadFromFile(string configFilePath, bool LoadDefaultOnError)
        {
            DefaultConfiguration ret = null;
            FileStream fileStream = null;
            XmlSerializer xmlSerializer = null;
            try
            {
                xmlSerializer = new XmlSerializer(typeof(DefaultConfiguration));
                fileStream = new FileStream(configFilePath, FileMode.Open);
                ret = (DefaultConfiguration)(xmlSerializer.Deserialize(fileStream));
                //me.PostDeserialization();
            }
            catch (Exception ex)
            {
                if (LoadDefaultOnError)
                {
                    ret = new DefaultConfiguration();
                    ret.SetDefaults();
                }
                else
                {
                    throw new Exception("GeocoderConfiguration: An error occured during reading/loading the xml configuration file.", ex);
                }
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return ret;
        }

        public override void SaveToFile(string configFilePath)
        {
            StreamWriter streamWriter = null;
            XmlSerializer xmlSerializer = null;
            try
            {
                if (!FileUtils.FileExists(configFilePath))
                {
                    FileUtils.CreateTextFile(configFilePath);
                }

                xmlSerializer = new XmlSerializer(typeof(DefaultConfiguration));
                File.SetAttributes(configFilePath, FileAttributes.Normal);
                streamWriter = new StreamWriter(configFilePath);
                xmlSerializer.Serialize(streamWriter, this);
            }
            catch (Exception ex)
            {
                throw new Exception("GeocoderConfiguration: An error occured during saving the xml configuration file.", ex);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }
    }
}
