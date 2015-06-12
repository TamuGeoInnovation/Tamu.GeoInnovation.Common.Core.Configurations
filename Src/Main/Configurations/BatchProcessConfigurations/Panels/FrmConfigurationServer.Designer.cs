namespace USC.GISResearchLab.Common.Core.Configurations.Panels
{
    partial class FrmConfigurationServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.txtLocalServer = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtLocalServerPass = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtLocalServerUser = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.chkDoNotStoreTransactionDetails = new System.Windows.Forms.CheckBox();
            this.txtRemoteServerHttpAddress = new System.Windows.Forms.TextBox();
            this.rdoRemoteSoap = new System.Windows.Forms.RadioButton();
            this.rdoRemoteHTTP = new System.Windows.Forms.RadioButton();
            this.txtRemoteServerSoapAddress = new System.Windows.Forms.TextBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.rdoLocalGeocoder = new System.Windows.Forms.RadioButton();
            this.rdoRemoteGeocoder = new System.Windows.Forms.RadioButton();
            this.groupBox9.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox16);
            this.groupBox9.Controls.Add(this.groupBox15);
            this.groupBox9.Controls.Add(this.rdoLocalGeocoder);
            this.groupBox9.Controls.Add(this.rdoRemoteGeocoder);
            this.groupBox9.Location = new System.Drawing.Point(12, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(488, 307);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Server Settings";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.txtLocalServer);
            this.groupBox16.Controls.Add(this.label33);
            this.groupBox16.Controls.Add(this.txtLocalServerPass);
            this.groupBox16.Controls.Add(this.label34);
            this.groupBox16.Controls.Add(this.label35);
            this.groupBox16.Controls.Add(this.txtLocalServerUser);
            this.groupBox16.Location = new System.Drawing.Point(28, 193);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(446, 100);
            this.groupBox16.TabIndex = 13;
            this.groupBox16.TabStop = false;
            // 
            // txtLocalServer
            // 
            this.txtLocalServer.Location = new System.Drawing.Point(66, 19);
            this.txtLocalServer.Name = "txtLocalServer";
            this.txtLocalServer.Size = new System.Drawing.Size(371, 20);
            this.txtLocalServer.TabIndex = 6;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(11, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 13);
            this.label33.TabIndex = 7;
            this.label33.Text = "Server";
            // 
            // txtLocalServerPass
            // 
            this.txtLocalServerPass.Location = new System.Drawing.Point(66, 71);
            this.txtLocalServerPass.Name = "txtLocalServerPass";
            this.txtLocalServerPass.Size = new System.Drawing.Size(371, 20);
            this.txtLocalServerPass.TabIndex = 10;
            this.txtLocalServerPass.UseSystemPasswordChar = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(11, 48);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 13);
            this.label34.TabIndex = 9;
            this.label34.Text = "User";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(11, 74);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(30, 13);
            this.label35.TabIndex = 11;
            this.label35.Text = "Pass";
            // 
            // txtLocalServerUser
            // 
            this.txtLocalServerUser.Location = new System.Drawing.Point(66, 45);
            this.txtLocalServerUser.Name = "txtLocalServerUser";
            this.txtLocalServerUser.Size = new System.Drawing.Size(371, 20);
            this.txtLocalServerUser.TabIndex = 8;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.chkDoNotStoreTransactionDetails);
            this.groupBox15.Controls.Add(this.txtRemoteServerHttpAddress);
            this.groupBox15.Controls.Add(this.rdoRemoteSoap);
            this.groupBox15.Controls.Add(this.rdoRemoteHTTP);
            this.groupBox15.Controls.Add(this.txtRemoteServerSoapAddress);
            this.groupBox15.Controls.Add(this.txtApiKey);
            this.groupBox15.Controls.Add(this.label32);
            this.groupBox15.Location = new System.Drawing.Point(28, 42);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(446, 122);
            this.groupBox15.TabIndex = 12;
            this.groupBox15.TabStop = false;
            // 
            // chkDoNotStoreTransactionDetails
            // 
            this.chkDoNotStoreTransactionDetails.AutoSize = true;
            this.chkDoNotStoreTransactionDetails.Location = new System.Drawing.Point(18, 93);
            this.chkDoNotStoreTransactionDetails.Name = "chkDoNotStoreTransactionDetails";
            this.chkDoNotStoreTransactionDetails.Size = new System.Drawing.Size(172, 17);
            this.chkDoNotStoreTransactionDetails.TabIndex = 66;
            this.chkDoNotStoreTransactionDetails.Text = "Do not store transaction details";
            this.chkDoNotStoreTransactionDetails.UseVisualStyleBackColor = true;
            // 
            // txtRemoteServerHttpAddress
            // 
            this.txtRemoteServerHttpAddress.Location = new System.Drawing.Point(66, 41);
            this.txtRemoteServerHttpAddress.Name = "txtRemoteServerHttpAddress";
            this.txtRemoteServerHttpAddress.Size = new System.Drawing.Size(371, 20);
            this.txtRemoteServerHttpAddress.TabIndex = 2;
            this.txtRemoteServerHttpAddress.Text = "https://webgis.usc.edu/Services/Geocode/WebService/GeocoderWebServiceHttpNonParse" +
                "d_V02_94.aspx";
            // 
            // rdoRemoteSoap
            // 
            this.rdoRemoteSoap.AutoSize = true;
            this.rdoRemoteSoap.Location = new System.Drawing.Point(6, 19);
            this.rdoRemoteSoap.Name = "rdoRemoteSoap";
            this.rdoRemoteSoap.Size = new System.Drawing.Size(54, 17);
            this.rdoRemoteSoap.TabIndex = 1;
            this.rdoRemoteSoap.Text = "SOAP";
            this.rdoRemoteSoap.UseVisualStyleBackColor = true;
            // 
            // rdoRemoteHTTP
            // 
            this.rdoRemoteHTTP.AutoSize = true;
            this.rdoRemoteHTTP.Checked = true;
            this.rdoRemoteHTTP.Location = new System.Drawing.Point(6, 42);
            this.rdoRemoteHTTP.Name = "rdoRemoteHTTP";
            this.rdoRemoteHTTP.Size = new System.Drawing.Size(54, 17);
            this.rdoRemoteHTTP.TabIndex = 0;
            this.rdoRemoteHTTP.TabStop = true;
            this.rdoRemoteHTTP.Text = "HTTP";
            this.rdoRemoteHTTP.UseVisualStyleBackColor = true;
            // 
            // txtRemoteServerSoapAddress
            // 
            this.txtRemoteServerSoapAddress.Location = new System.Drawing.Point(66, 18);
            this.txtRemoteServerSoapAddress.Name = "txtRemoteServerSoapAddress";
            this.txtRemoteServerSoapAddress.Size = new System.Drawing.Size(371, 20);
            this.txtRemoteServerSoapAddress.TabIndex = 0;
            this.txtRemoteServerSoapAddress.Text = "https://webgis.usc.edu/Services/Geocode/WebService/GeocoderService_V02_94.asmx";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(66, 67);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(371, 20);
            this.txtApiKey.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 13);
            this.label32.TabIndex = 3;
            this.label32.Text = "API Key";
            // 
            // rdoLocalGeocoder
            // 
            this.rdoLocalGeocoder.AutoSize = true;
            this.rdoLocalGeocoder.Checked = true;
            this.rdoLocalGeocoder.Location = new System.Drawing.Point(6, 170);
            this.rdoLocalGeocoder.Name = "rdoLocalGeocoder";
            this.rdoLocalGeocoder.Size = new System.Drawing.Size(101, 17);
            this.rdoLocalGeocoder.TabIndex = 5;
            this.rdoLocalGeocoder.TabStop = true;
            this.rdoLocalGeocoder.Text = "Local Geocoder";
            this.rdoLocalGeocoder.UseVisualStyleBackColor = true;
            // 
            // rdoRemoteGeocoder
            // 
            this.rdoRemoteGeocoder.AutoSize = true;
            this.rdoRemoteGeocoder.Location = new System.Drawing.Point(10, 19);
            this.rdoRemoteGeocoder.Name = "rdoRemoteGeocoder";
            this.rdoRemoteGeocoder.Size = new System.Drawing.Size(112, 17);
            this.rdoRemoteGeocoder.TabIndex = 4;
            this.rdoRemoteGeocoder.Text = "Remote Geocoder";
            this.rdoRemoteGeocoder.UseVisualStyleBackColor = true;
            // 
            // FrmConfigurationServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 331);
            this.Controls.Add(this.groupBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigurationServer";
            this.Load += new System.EventHandler(this.FrmConfigurationServer_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox txtLocalServer;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtLocalServerPass;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtLocalServerUser;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.CheckBox chkDoNotStoreTransactionDetails;
        private System.Windows.Forms.TextBox txtRemoteServerHttpAddress;
        private System.Windows.Forms.RadioButton rdoRemoteSoap;
        private System.Windows.Forms.RadioButton rdoRemoteHTTP;
        private System.Windows.Forms.TextBox txtRemoteServerSoapAddress;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RadioButton rdoLocalGeocoder;
        private System.Windows.Forms.RadioButton rdoRemoteGeocoder;
    }
}