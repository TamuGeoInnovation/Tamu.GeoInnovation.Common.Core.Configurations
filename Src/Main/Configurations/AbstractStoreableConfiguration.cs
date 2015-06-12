using System;
using System.Collections.Generic;
using System.Text;
using USC.GISResearchLab.Common.Core.Configurations.Interfaces;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace USC.GISResearchLab.Common.Core.Configurations
{
    public abstract class AbstractStoreableConfiguration : IConfiguration
    {
        public string MyName { get; set; }
        [XmlIgnore]
        public TraceSource MyTraceSource { get; set; }

        public abstract void SetToDefault();

        public new abstract string ToString();

        public static T LoadFormXMLFile<T>(string filename, bool LoadDefaultOnError) where T : AbstractStoreableConfiguration
        {
            FileStream myFileStream = null;
            XmlSerializer mySerializer = null;
            T me = default(T);
            var type = typeof(T);

            try
            {
                mySerializer = new XmlSerializer(type);
                myFileStream = new FileStream(filename, FileMode.Open);
                me = (T)(mySerializer.Deserialize(myFileStream));
            }
            catch (Exception ex)
            {
                if (LoadDefaultOnError)
                {
                    me = Activator.CreateInstance<T>();
                    me.SetToDefault();
                }
                else throw new Exception(type.Name + ": An error occured during reading/loading the xml configuration file.", ex);
            }
            finally
            {
                if (myFileStream != null) myFileStream.Close();
            }

            return me;
        }

        public void SaveToFile(string filename)
        {
            StreamWriter myWriter = null;
            XmlSerializer mySerializer = null;
            try
            {
                mySerializer = new XmlSerializer(this.GetType());
                if (File.Exists(filename)) File.SetAttributes(filename, FileAttributes.Normal);
                myWriter = new StreamWriter(filename);
                mySerializer.Serialize(myWriter, this);
            }
            catch (Exception ex)
            {
                throw new Exception(this.GetType().Name + ": An error occured during saving the xml configuration file.", ex);
            }
            finally
            {
                if (myWriter != null) myWriter.Close();
            }
        }
    }
}
