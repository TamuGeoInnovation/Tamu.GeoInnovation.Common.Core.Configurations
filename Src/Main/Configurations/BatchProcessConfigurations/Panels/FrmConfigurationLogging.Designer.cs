namespace USC.GISResearchLab.Common.Core.Configurations.Panels
{
    partial class FrmConfigurationLogging
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtLogFilePath = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.rdoFeatureMemoryCacheTrue = new System.Windows.Forms.RadioButton();
            this.rdoShouldLog = new System.Windows.Forms.RadioButton();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnBrowse);
            this.groupBox6.Controls.Add(this.txtLogFilePath);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.rdoFeatureMemoryCacheTrue);
            this.groupBox6.Controls.Add(this.rdoShouldLog);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(505, 97);
            this.groupBox6.TabIndex = 73;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Logging Options";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(435, 63);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 23);
            this.btnBrowse.TabIndex = 76;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtLogFilePath
            // 
            this.txtLogFilePath.Location = new System.Drawing.Point(58, 65);
            this.txtLogFilePath.Name = "txtLogFilePath";
            this.txtLogFilePath.Size = new System.Drawing.Size(371, 20);
            this.txtLogFilePath.TabIndex = 74;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(29, 68);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 13);
            this.label32.TabIndex = 75;
            this.label32.Text = "File";
            // 
            // rdoFeatureMemoryCacheTrue
            // 
            this.rdoFeatureMemoryCacheTrue.AutoSize = true;
            this.rdoFeatureMemoryCacheTrue.Checked = true;
            this.rdoFeatureMemoryCacheTrue.Location = new System.Drawing.Point(6, 19);
            this.rdoFeatureMemoryCacheTrue.Name = "rdoFeatureMemoryCacheTrue";
            this.rdoFeatureMemoryCacheTrue.Size = new System.Drawing.Size(123, 17);
            this.rdoFeatureMemoryCacheTrue.TabIndex = 67;
            this.rdoFeatureMemoryCacheTrue.TabStop = true;
            this.rdoFeatureMemoryCacheTrue.Text = "Do not create log file";
            this.rdoFeatureMemoryCacheTrue.UseVisualStyleBackColor = true;
            // 
            // rdoShouldLog
            // 
            this.rdoShouldLog.AutoSize = true;
            this.rdoShouldLog.Location = new System.Drawing.Point(6, 42);
            this.rdoShouldLog.Name = "rdoShouldLog";
            this.rdoShouldLog.Size = new System.Drawing.Size(89, 17);
            this.rdoShouldLog.TabIndex = 68;
            this.rdoShouldLog.Text = "Create log file";
            this.rdoShouldLog.UseVisualStyleBackColor = true;
            // 
            // FrmConfigurationLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 125);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigurationLogging";
            this.Load += new System.EventHandler(this.FrmConfigurationLogging_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdoFeatureMemoryCacheTrue;
        private System.Windows.Forms.RadioButton rdoShouldLog;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtLogFilePath;
        private System.Windows.Forms.Label label32;
    }
}