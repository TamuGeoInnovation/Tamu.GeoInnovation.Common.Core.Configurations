using System;
using System.Windows.Forms;

namespace USC.GISResearchLab.Common.Core.Configurations.Panels
{
    public partial class FrmConfigurationOptimizations : Form
    {
        #region Properties

        public AbstractConfiguration Configuration { get; set; }

        #endregion

        public FrmConfigurationOptimizations(AbstractConfiguration configuration)
        {
            Configuration = configuration;

            InitializeComponent();
        }

        public void BindToConfiguration()
        {
            rdoMultiThreaded.DataBindings.Add("Checked", Configuration.OptimizationConfiguration, "ShouldUseMultithreadedGeocoder", true, DataSourceUpdateMode.OnPropertyChanged);
            chkShouldKeepInputDbOpen.DataBindings.Add("Checked", Configuration.OptimizationConfiguration, "ShouldKeepInputDatabaseConnectionOpen", true, DataSourceUpdateMode.OnPropertyChanged);
            chkShouldKeepOutputTextFileOpen.DataBindings.Add("Checked", Configuration.OptimizationConfiguration, "ShouldKeepOutputTextFileOpen", true, DataSourceUpdateMode.OnPropertyChanged);
            rdoShouldUseDataReader.DataBindings.Add("Checked", Configuration.OptimizationConfiguration, "ShouldUseDataReader", true, DataSourceUpdateMode.OnPropertyChanged);
            chkOrderByIdField.DataBindings.Add("Checked", Configuration.OptimizationConfiguration, "ShouldOrderByIdField", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FrmConfigurationOptimizations_Load(object sender, EventArgs e)
        {
            BindToConfiguration();
        }
    }
}
