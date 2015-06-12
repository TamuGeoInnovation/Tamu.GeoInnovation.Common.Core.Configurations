namespace USC.GISResearchLab.Common.Core.Configurations.ConfigurationPanels.Interfaces
{
    public interface IConfigurationPanel
    {
        string MyName { get; }
        void BindToConfiguration();
    }
}
