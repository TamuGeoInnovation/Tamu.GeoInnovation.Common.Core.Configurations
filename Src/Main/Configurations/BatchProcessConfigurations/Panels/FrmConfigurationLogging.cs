using System;
using System.Windows.Forms;
using USC.GISResearchLab.Common.Utils.FileBrowsers;
using USC.GISResearchLab.Common.Utils.Strings;


namespace USC.GISResearchLab.Common.Core.Configurations.Panels
{
    public partial class FrmConfigurationLogging : Form
    {
        #region Properties

        public AbstractConfiguration Configuration { get; set; }

        #endregion

        public FrmConfigurationLogging(AbstractConfiguration configuration)
        {
            Configuration = configuration;

            InitializeComponent();
        }

        public void BindToConfiguration()
        {
            rdoShouldLog.DataBindings.Add("Checked", Configuration.LoggingConfiguration, "ShouldLog", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLogFilePath.DataBindings.Add("Text", Configuration.LoggingConfiguration, "LogFilePath", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string initialPath = null;
            if (!String.IsNullOrEmpty(txtLogFilePath.Text))
            {
                initialPath = txtLogFilePath.Text;
            }

            string path = FileBrowserUtils.BrowseAndSelectSaveFile(FileBrowserUtils.TYPE_TEXT, "Select log file", initialPath);
            if (!StringUtils.IsEmpty(path))
            {
                txtLogFilePath.Text = path;
            }
        }

        private void FrmConfigurationLogging_Load(object sender, EventArgs e)
        {
            BindToConfiguration();
        }
    }
}
