namespace USC.GISResearchLab.Common.Core.Configurations.Panels
{
    partial class FrmConfigurationOptimizations
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
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.rdoMultiThreaded = new System.Windows.Forms.RadioButton();
            this.rdoSingleThreaded = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkOrderByIdField = new System.Windows.Forms.CheckBox();
            this.rdoShouldNotUseDataReader = new System.Windows.Forms.RadioButton();
            this.rdoShouldUseDataReader = new System.Windows.Forms.RadioButton();
            this.chkShouldKeepInputDbOpen = new System.Windows.Forms.CheckBox();
            this.chkShouldKeepOutputTextFileOpen = new System.Windows.Forms.CheckBox();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.chkShouldKeepOutputTextFileOpen);
            this.groupBox14.Controls.Add(this.chkShouldKeepInputDbOpen);
            this.groupBox14.Location = new System.Drawing.Point(12, 87);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(208, 131);
            this.groupBox14.TabIndex = 75;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "File Connections";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.rdoMultiThreaded);
            this.groupBox13.Controls.Add(this.rdoSingleThreaded);
            this.groupBox13.Location = new System.Drawing.Point(12, 12);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(208, 69);
            this.groupBox13.TabIndex = 74;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Threading";
            // 
            // rdoMultiThreaded
            // 
            this.rdoMultiThreaded.AutoSize = true;
            this.rdoMultiThreaded.Enabled = false;
            this.rdoMultiThreaded.Location = new System.Drawing.Point(6, 42);
            this.rdoMultiThreaded.Name = "rdoMultiThreaded";
            this.rdoMultiThreaded.Size = new System.Drawing.Size(89, 17);
            this.rdoMultiThreaded.TabIndex = 67;
            this.rdoMultiThreaded.Text = "Multithreaded";
            this.rdoMultiThreaded.UseVisualStyleBackColor = true;
            // 
            // rdoSingleThreaded
            // 
            this.rdoSingleThreaded.AutoSize = true;
            this.rdoSingleThreaded.Checked = true;
            this.rdoSingleThreaded.Location = new System.Drawing.Point(6, 19);
            this.rdoSingleThreaded.Name = "rdoSingleThreaded";
            this.rdoSingleThreaded.Size = new System.Drawing.Size(103, 17);
            this.rdoSingleThreaded.TabIndex = 68;
            this.rdoSingleThreaded.TabStop = true;
            this.rdoSingleThreaded.Text = "Single Threaded";
            this.rdoSingleThreaded.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOrderByIdField);
            this.groupBox2.Controls.Add(this.rdoShouldNotUseDataReader);
            this.groupBox2.Controls.Add(this.rdoShouldUseDataReader);
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 105);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Work Table";
            // 
            // chkOrderByIdField
            // 
            this.chkOrderByIdField.AutoSize = true;
            this.chkOrderByIdField.Location = new System.Drawing.Point(7, 66);
            this.chkOrderByIdField.Name = "chkOrderByIdField";
            this.chkOrderByIdField.Size = new System.Drawing.Size(99, 17);
            this.chkOrderByIdField.TabIndex = 69;
            this.chkOrderByIdField.Text = "Order by id field";
            this.chkOrderByIdField.UseVisualStyleBackColor = true;
            // 
            // rdoShouldNotUseDataReader
            // 
            this.rdoShouldNotUseDataReader.AutoSize = true;
            this.rdoShouldNotUseDataReader.Checked = true;
            this.rdoShouldNotUseDataReader.Location = new System.Drawing.Point(6, 42);
            this.rdoShouldNotUseDataReader.Name = "rdoShouldNotUseDataReader";
            this.rdoShouldNotUseDataReader.Size = new System.Drawing.Size(100, 17);
            this.rdoShouldNotUseDataReader.TabIndex = 67;
            this.rdoShouldNotUseDataReader.TabStop = true;
            this.rdoShouldNotUseDataReader.Text = "Use Data Table";
            this.rdoShouldNotUseDataReader.UseVisualStyleBackColor = true;
            // 
            // rdoShouldUseDataReader
            // 
            this.rdoShouldUseDataReader.AutoSize = true;
            this.rdoShouldUseDataReader.Location = new System.Drawing.Point(6, 19);
            this.rdoShouldUseDataReader.Name = "rdoShouldUseDataReader";
            this.rdoShouldUseDataReader.Size = new System.Drawing.Size(108, 17);
            this.rdoShouldUseDataReader.TabIndex = 68;
            this.rdoShouldUseDataReader.Text = "Use Data Reader";
            this.rdoShouldUseDataReader.UseVisualStyleBackColor = true;
            // 
            // chkShouldKeepInputDbOpen
            // 
            this.chkShouldKeepInputDbOpen.AutoSize = true;
            this.chkShouldKeepInputDbOpen.Location = new System.Drawing.Point(7, 19);
            this.chkShouldKeepInputDbOpen.Name = "chkShouldKeepInputDbOpen";
            this.chkShouldKeepInputDbOpen.Size = new System.Drawing.Size(151, 17);
            this.chkShouldKeepInputDbOpen.TabIndex = 70;
            this.chkShouldKeepInputDbOpen.Text = "Keep input database open";
            this.chkShouldKeepInputDbOpen.UseVisualStyleBackColor = true;
            // 
            // chkShouldKeepOutputTextFileOpen
            // 
            this.chkShouldKeepOutputTextFileOpen.AutoSize = true;
            this.chkShouldKeepOutputTextFileOpen.Location = new System.Drawing.Point(7, 42);
            this.chkShouldKeepOutputTextFileOpen.Name = "chkShouldKeepOutputTextFileOpen";
            this.chkShouldKeepOutputTextFileOpen.Size = new System.Drawing.Size(147, 17);
            this.chkShouldKeepOutputTextFileOpen.TabIndex = 71;
            this.chkShouldKeepOutputTextFileOpen.Text = "Keep output text file open";
            this.chkShouldKeepOutputTextFileOpen.UseVisualStyleBackColor = true;
            // 
            // FrmConfigurationOptimizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigurationOptimizations";
            this.Load += new System.EventHandler(this.FrmConfigurationOptimizations_Load);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton rdoMultiThreaded;
        private System.Windows.Forms.RadioButton rdoSingleThreaded;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoShouldNotUseDataReader;
        private System.Windows.Forms.RadioButton rdoShouldUseDataReader;
        private System.Windows.Forms.CheckBox chkOrderByIdField;
        private System.Windows.Forms.CheckBox chkShouldKeepInputDbOpen;
        private System.Windows.Forms.CheckBox chkShouldKeepOutputTextFileOpen;
    }
}