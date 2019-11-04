using System;

namespace USC.GISResearchLab.Common.Core.Configurations
{
    [Serializable]
    public abstract class AbstractServerConfiguration
    {
        public bool ShouldUseRemoteServer { get; set; }
        public bool ShouldUseSoapClient { get; set; }

        public string ApiSoapUrl { get; set; }
        public string ApiHttpUrl { get; set; }
        public string ApiKey { get; set; }

        public bool ShouldNotStoreTransactionDetails { get; set; }

        public string LocalServerPath { get; set; }
        public string LocalServerUserName { get; set; }
        public string LocalServerPassword { get; set; }

        public abstract string DeafultApiSoapUrl { get; }
        public abstract string DeafultApiHttpUrl { get; }

        public AbstractServerConfiguration(string server, string userName, string password)
        {
            ApiSoapUrl = "";
            ApiHttpUrl = "";
            ApiKey = "";

            LocalServerPath = server;
            LocalServerUserName = userName;
            LocalServerPassword = password;
        }

        public AbstractServerConfiguration() : this(null, null, null) { }

        public void SetDefaults()
        {
            ShouldUseRemoteServer = true;
            ShouldUseSoapClient = true;
            ApiSoapUrl = DeafultApiSoapUrl;
            ApiHttpUrl = DeafultApiHttpUrl;

        }
    }
}
