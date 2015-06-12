namespace USC.GISResearchLab.Common.Core.Configurations.Interfaces
{
    public interface IConfiguration
    {
        string MyName { get; set; }

        void SetToDefault();

        string ToString();
    }
}
