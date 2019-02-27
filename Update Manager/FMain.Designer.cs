namespace Aldrigo.UltraUpdater.Manager {
    partial class FMain {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.BtMakeFirstRel = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.BtMakeUpdate = new System.Windows.Forms.Button();
            this.BtCreateSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtMakeFirstRel
            // 
            this.BtMakeFirstRel.Location = new System.Drawing.Point(12, 12);
            this.BtMakeFirstRel.Name = "BtMakeFirstRel";
            this.BtMakeFirstRel.Size = new System.Drawing.Size(127, 23);
            this.BtMakeFirstRel.TabIndex = 0;
            this.BtMakeFirstRel.Text = "Make First Release";
            this.BtMakeFirstRel.UseVisualStyleBackColor = true;
            this.BtMakeFirstRel.Click += new System.EventHandler(this.BtMakeFirstRel_Click);
            // 
            // BtMakeUpdate
            // 
            this.BtMakeUpdate.Location = new System.Drawing.Point(12, 41);
            this.BtMakeUpdate.Name = "BtMakeUpdate";
            this.BtMakeUpdate.Size = new System.Drawing.Size(127, 23);
            this.BtMakeUpdate.TabIndex = 1;
            this.BtMakeUpdate.Text = "Make Update!";
            this.BtMakeUpdate.UseVisualStyleBackColor = true;
            this.BtMakeUpdate.Click += new System.EventHandler(this.BtMakeUpdate_Click);
            // 
            // BtCreateSettings
            // 
            this.BtCreateSettings.Location = new System.Drawing.Point(12, 92);
            this.BtCreateSettings.Name = "BtCreateSettings";
            this.BtCreateSettings.Size = new System.Drawing.Size(127, 23);
            this.BtCreateSettings.TabIndex = 2;
            this.BtCreateSettings.Text = "Create settings.xml";
            this.BtCreateSettings.UseVisualStyleBackColor = true;
            this.BtCreateSettings.Click += new System.EventHandler(this.BtCreateSettings_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 139);
            this.Controls.Add(this.BtCreateSettings);
            this.Controls.Add(this.BtMakeUpdate);
            this.Controls.Add(this.BtMakeFirstRel);
            this.Name = "FMain";
            this.Text = "Update Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtMakeFirstRel;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Button BtMakeUpdate;
        private System.Windows.Forms.Button BtCreateSettings;
    }
}

