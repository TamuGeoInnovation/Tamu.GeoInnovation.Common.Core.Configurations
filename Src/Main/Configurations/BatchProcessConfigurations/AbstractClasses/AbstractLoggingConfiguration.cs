using System;
using System.IO;
using System.Reflection;
using USC.GISResearchLab.Common.Utils.Files;

namespace USC.GISResearchLab.Common.Core.Configurations
{
    [Serializable]
    public abstract class AbstractLoggingConfiguration
    {
        public bool ShouldLog { get; set; }
        public string LogFilePath { get; set; }
        public string TraceLevelString { get; set; }
        public int TraceLevel { get; set; }


        public AbstractLoggingConfiguration()
        {
            LogFilePath = "";
        }

        public void SetDefaults()
        {
            ShouldLog = false;
            string executingFilePath = Assembly.GetExecutingAssembly().Location;
            LogFilePath = Path.Combine(FileUtils.GetDirectoryPath(executingFilePath), "log.txt");
            TraceLevelString = "0";
            TraceLevel = 0;
        }
    }
}
