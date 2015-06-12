using System;
using System.Windows.Forms;

namespace USC.GISResearchLab.Common.Core.Configurations.Panels
{
    public partial class FrmConfigurationServer : Form
    {
        #region Properties

        public AbstractConfiguration Configuration { get; set; }

        #endregion

        public FrmConfigurationServer(AbstractConfiguration configuration)
        {
            Configuration = configuration;

            InitializeComponent();
        }

        public void BindToConfiguration()
        {
            rdoRemoteGeocoder.DataBindings.Add("Checked", Configuration.ServerConfiguration, "ShouldUseRemoteServer", true, DataSourceUpdateMode.OnPropertyChanged);
            rdoRemoteSoap.DataBindings.Add("Checked", Configuration.ServerConfiguration, "ShouldUseSoapClient", true, DataSourceUpdateMode.OnPropertyChanged);

            txtRemoteServerHttpAddress.DataBindings.Add("Text", Configuration.ServerConfiguration, "ApiHttpUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRemoteServerSoapAddress.DataBindings.Add("Text", Configuration.ServerConfiguration, "ApiSoapUrl", true, DataSourceUpdateMode.OnPropertyChanged);

            txtApiKey.DataBindings.Add("Text", Configuration.ServerConfiguration, "ApiKey", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalServer.DataBindings.Add("Text", Configuration.ServerConfiguration, "LocalServerPath", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalServerPass.DataBindings.Add("Text", Configuration.ServerConfiguration, "LocalServerPassword", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalServerUser.DataBindings.Add("Text", Configuration.ServerConfiguration, "LocalServerUserName", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void FrmConfigurationServer_Load(object sender, EventArgs e)
        {
            BindToConfiguration();
        }
    }
}
