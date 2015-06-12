using System;

namespace USC.GISResearchLab.Common.Core.Configurations
{
    [Serializable]
    public abstract class AbstractOptimizationConfiguration
    {
        public bool ShouldUseFeatureMemoryCache { get; set; }
        public bool ShouldUseMultithreadedGeocoder { get; set; }
        public bool ShouldKeepInputDatabaseConnectionOpen { get; set; }
        public bool ShouldUseDataReader { get; set; }
        public bool ShouldOrderByIdField { get; set; }
        public bool ShouldKeepOutputTextFileOpen { get; set; }

        public AbstractOptimizationConfiguration()
        {
        }

        public void SetDefaults()
        {
            ShouldKeepOutputTextFileOpen = true;
            ShouldKeepInputDatabaseConnectionOpen = true;
            ShouldUseDataReader = true;
            ShouldOrderByIdField = true;
        }
    }
}
