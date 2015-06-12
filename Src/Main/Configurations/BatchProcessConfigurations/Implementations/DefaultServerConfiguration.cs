using System;

namespace USC.GISResearchLab.Common.Core.Configurations
{
    [Serializable]
    public class DefaultServerConfiguration: AbstractServerConfiguration
    {

        #region Properties

        public override string DeafultApiSoapUrl { get { return ""; } }
        public override string DeafultApiHttpUrl { get { return ""; } }

        #endregion

        public DefaultServerConfiguration(string server, string userName, string password): base(server, userName, password){}

        public DefaultServerConfiguration() : base(null, null, null) { }

    }
}
