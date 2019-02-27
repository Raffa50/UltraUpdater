namespace Aldrigos.UltraUpdater.Updater
{
    partial class Fmain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmain));
            this.mplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblstatus = new System.Windows.Forms.Label();
            this.progbar = new System.Windows.Forms.ProgressBar();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.lblver = new System.Windows.Forms.Label();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.mplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mplayer
            // 
            this.mplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mplayer.Enabled = true;
            this.mplayer.Location = new System.Drawing.Point(2, 3);
            this.mplayer.Name = "mplayer";
            this.mplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mplayer.OcxState")));
            this.mplayer.Size = new System.Drawing.Size(482, 192);
            this.mplayer.TabIndex = 0;
            this.mplayer.Visible = false;
            // 
            // lblstatus
            // 
            this.lblstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(12, 208);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(251, 15);
            this.lblstatus.TabIndex = 1;
            this.lblstatus.Text = "Downloading version information from server";
            // 
            // progbar
            // 
            this.progbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progbar.Location = new System.Drawing.Point(15, 226);
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(458, 23);
            this.progbar.TabIndex = 2;
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnupdate.Enabled = false;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(15, 266);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 36);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnplay
            // 
            this.btnplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnplay.Enabled = false;
            this.btnplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Location = new System.Drawing.Point(134, 266);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(96, 36);
            this.btnplay.TabIndex = 4;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            // 
            // lblver
            // 
            this.lblver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblver.AutoSize = true;
            this.lblver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblver.Location = new System.Drawing.Point(338, 266);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(17, 15);
            this.lblver.TabIndex = 5;
            this.lblver.Text = "V ";
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser1.Location = new System.Drawing.Point(2, 3);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(482, 192);
            this.WebBrowser1.TabIndex = 6;
            this.WebBrowser1.Visible = false;
            // 
            // Fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 314);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.lblver);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.progbar);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.mplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fmain";
            this.Text = "Ultra Updater";
            this.Load += new System.EventHandler(this.Fmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mplayer;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ProgressBar progbar;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnplay;
        internal System.Windows.Forms.Label lblver;
        internal System.Windows.Forms.WebBrowser WebBrowser1;
    }
}

