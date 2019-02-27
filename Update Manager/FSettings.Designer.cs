namespace Aldrigo.UltraUpdater.Manager {
    partial class FSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.NuFormWidth = new System.Windows.Forms.NumericUpDown();
            this.NuFormHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RbNoMedia = new System.Windows.Forms.RadioButton();
            this.RbMediaAudio = new System.Windows.Forms.RadioButton();
            this.RbMediaVideo = new System.Windows.Forms.RadioButton();
            this.TbMediaPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbSplashUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbDownloadUrl = new System.Windows.Forms.TextBox();
            this.btMakeSettings = new System.Windows.Forms.Button();
            this.Fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.TbShell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NuFormWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuFormHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // NuFormWidth
            // 
            this.NuFormWidth.Location = new System.Drawing.Point(12, 39);
            this.NuFormWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NuFormWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NuFormWidth.Name = "NuFormWidth";
            this.NuFormWidth.Size = new System.Drawing.Size(91, 20);
            this.NuFormWidth.TabIndex = 0;
            this.NuFormWidth.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            // 
            // NuFormHeight
            // 
            this.NuFormHeight.Location = new System.Drawing.Point(109, 39);
            this.NuFormHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NuFormHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NuFormHeight.Name = "NuFormHeight";
            this.NuFormHeight.Size = new System.Drawing.Size(91, 20);
            this.NuFormHeight.TabIndex = 1;
            this.NuFormHeight.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Form Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Form Height";
            // 
            // RbNoMedia
            // 
            this.RbNoMedia.AutoSize = true;
            this.RbNoMedia.Checked = true;
            this.RbNoMedia.Location = new System.Drawing.Point(15, 88);
            this.RbNoMedia.Name = "RbNoMedia";
            this.RbNoMedia.Size = new System.Drawing.Size(71, 17);
            this.RbNoMedia.TabIndex = 4;
            this.RbNoMedia.TabStop = true;
            this.RbNoMedia.Text = "No Media";
            this.RbNoMedia.UseVisualStyleBackColor = true;
            // 
            // RbMediaAudio
            // 
            this.RbMediaAudio.AutoSize = true;
            this.RbMediaAudio.Location = new System.Drawing.Point(92, 88);
            this.RbMediaAudio.Name = "RbMediaAudio";
            this.RbMediaAudio.Size = new System.Drawing.Size(52, 17);
            this.RbMediaAudio.TabIndex = 5;
            this.RbMediaAudio.Text = "Audio";
            this.RbMediaAudio.UseVisualStyleBackColor = true;
            // 
            // RbMediaVideo
            // 
            this.RbMediaVideo.AutoSize = true;
            this.RbMediaVideo.Location = new System.Drawing.Point(150, 88);
            this.RbMediaVideo.Name = "RbMediaVideo";
            this.RbMediaVideo.Size = new System.Drawing.Size(52, 17);
            this.RbMediaVideo.TabIndex = 6;
            this.RbMediaVideo.Text = "Video";
            this.RbMediaVideo.UseVisualStyleBackColor = true;
            // 
            // TbMediaPath
            // 
            this.TbMediaPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbMediaPath.Location = new System.Drawing.Point(89, 111);
            this.TbMediaPath.Name = "TbMediaPath";
            this.TbMediaPath.Size = new System.Drawing.Size(187, 20);
            this.TbMediaPath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Relative FullPath";
            // 
            // TbSplashUrl
            // 
            this.TbSplashUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSplashUrl.Location = new System.Drawing.Point(89, 154);
            this.TbSplashUrl.Name = "TbSplashUrl";
            this.TbSplashUrl.Size = new System.Drawing.Size(187, 20);
            this.TbSplashUrl.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Site Splah Url";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Download Url";
            // 
            // TbDownloadUrl
            // 
            this.TbDownloadUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDownloadUrl.Location = new System.Drawing.Point(89, 201);
            this.TbDownloadUrl.Name = "TbDownloadUrl";
            this.TbDownloadUrl.Size = new System.Drawing.Size(187, 20);
            this.TbDownloadUrl.TabIndex = 12;
            // 
            // btMakeSettings
            // 
            this.btMakeSettings.Location = new System.Drawing.Point(11, 295);
            this.btMakeSettings.Name = "btMakeSettings";
            this.btMakeSettings.Size = new System.Drawing.Size(75, 23);
            this.btMakeSettings.TabIndex = 13;
            this.btMakeSettings.Text = "Make!";
            this.btMakeSettings.UseVisualStyleBackColor = true;
            this.btMakeSettings.Click += new System.EventHandler(this.btMakeSettings_Click);
            // 
            // TbShell
            // 
            this.TbShell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbShell.Location = new System.Drawing.Point(114, 242);
            this.TbShell.Name = "TbShell";
            this.TbShell.Size = new System.Drawing.Size(162, 20);
            this.TbShell.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Shell (relative .exe)";
            // 
            // FSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 330);
            this.Controls.Add(this.TbShell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btMakeSettings);
            this.Controls.Add(this.TbDownloadUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbSplashUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbMediaPath);
            this.Controls.Add(this.RbMediaVideo);
            this.Controls.Add(this.RbMediaAudio);
            this.Controls.Add(this.RbNoMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuFormHeight);
            this.Controls.Add(this.NuFormWidth);
            this.Name = "FSettings";
            this.Text = "Settings.xml Maker";
            ((System.ComponentModel.ISupportInitialize)(this.NuFormWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuFormHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NuFormWidth;
        private System.Windows.Forms.NumericUpDown NuFormHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbNoMedia;
        private System.Windows.Forms.RadioButton RbMediaAudio;
        private System.Windows.Forms.RadioButton RbMediaVideo;
        private System.Windows.Forms.TextBox TbMediaPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbSplashUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbDownloadUrl;
        private System.Windows.Forms.Button btMakeSettings;
        private System.Windows.Forms.FolderBrowserDialog Fbd;
        private System.Windows.Forms.TextBox TbShell;
        private System.Windows.Forms.Label label6;
    }
}