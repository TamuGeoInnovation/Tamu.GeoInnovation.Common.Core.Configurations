using System;
using System.IO;
using System.Xml.Serialization;

namespace USC.GISResearchLab.Common.Core.Configurations
{
    public static class StoreableConfiguration
    {
        public static void LoadFormXMLFile<T>(out T me, string filename) where T : new()
        {
            LoadFormXMLFile<T>(out me, filename, true);
        }

        public static void LoadFormXMLFile<T>(out T me, string filename, bool LoadDefaultOnError) where T : new()
        {
            FileStream myFileStream = null;
            XmlSerializer mySerializer = null;
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
                    me = new T();
                }
                else throw new Exception(type.Name + ": An error occured during reading/loading the xml configuration file.", ex);
            }
            finally
            {
                if (myFileStream != null) myFileStream.Close();
            }
        }

        public static void SaveToXmlFile(this object T, string filename)
        {
            StreamWriter myWriter = null;
            XmlSerializer mySerializer = null;

            try
            {
                if (T != null)
                {
                    mySerializer = new XmlSerializer(T.GetType());
                    if (File.Exists(filename)) File.SetAttributes(filename, FileAttributes.Normal);
                    myWriter = new StreamWriter(filename);
                    mySerializer.Serialize(myWriter, T);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(T.GetType().Name + ": An error occured during saving the xml configuration file.", ex);
            }
            finally
            {
                if (myWriter != null) myWriter.Close();
            }
        }

        static public Type GetDeclaredType<TSelf>(TSelf self)
        {
            return typeof(TSelf);
        }
    }
}
