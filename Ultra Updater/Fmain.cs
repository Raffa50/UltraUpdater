using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using Aldrigos.UltraUpdater.Data;
using Aldrigos.UltraUpdater.Interfaces;

namespace Aldrigos.UltraUpdater.Updater
{
    public partial class Fmain : Form
    {
        IUpdater myupdater;
        private IApplicationVersion _latestVersion;
        private string downloadsite, shellapp;
        public bool UpdateUpdater = true;

        public string YourFilesPath => Application.StartupPath + Path.DirectorySeparatorChar + "app";

        public string UpdaterUpdatesPath => YourFilesPath + Path.DirectorySeparatorChar + "Updater";

        public Fmain()
        {
            InitializeComponent();
        }

        private async void Fmain_Load(object sender, EventArgs e) {
            if( !ReadSettings() )
                return;
            myupdater = new UpdaterFactory().CreateNew( downloadsite, YourFilesPath );
            IApplicationVersion appVersion;

            try
            {
                appVersion= await myupdater.GetLatestVersion();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                lblstatus.Text = "Failed to connect to download site";
                lblstatus.ForeColor = Color.Red;
                return;
            }

            NewVersionDownloaded(appVersion);
        }

        private void NewVersionDownloaded( IApplicationVersion version ) {
            _latestVersion = version;
            lblver.Text = version.Version.ToString();

            if( !myupdater.IsUpdated( _latestVersion ) ) {
                lblstatus.Text = "Update aviable!";
                btnupdate.Enabled = true;
                lblstatus.ForeColor = Color.Green;
            } else {
                lblstatus.Text = "Updated!";
                btnupdate.Enabled = false;
                lblstatus.ForeColor = Color.Green;
                btnplay.Enabled = true;
            }
        }

        private bool ReadSettings() {
            SettingsData settings = null;
            try {
                var reader = new XmlSerializer( typeof( SettingsData ) );
                using( var file = new StreamReader( "settings.xml" ) ) {
                    settings = (SettingsData) reader.Deserialize( file );
                }
            }
            catch( Exception e ) {
                MessageBox.Show( "Can't read settings.xml!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                lblstatus.Text = "Unable to read settings!";
                lblstatus.ForeColor = Color.Red;
                return false;
            }

            if( settings.Media == null ) {
                mplayer.Visible = false;
            }
            else {
                if( settings.Media.Type == MediaType.Audio )
                    mplayer.Visible = false;
                else
                    mplayer.Visible = true;

                mplayer.URL = settings.Media.Path;
            }

            this.Width = settings.FormWidth;
            this.Height = settings.FormHeight;

            shellapp = settings.Shell;
            if( string.IsNullOrEmpty( shellapp ) ) btnplay.Visible = false;

            downloadsite = settings.DownloadSiteUrl;

            if( settings.SiteSplashUrl != null ) {
                WebBrowser1.Visible = true;
                WebBrowser1.Navigate( settings.SiteSplashUrl );
            }

            return true;
        }

        private async void btnupdate_Click(object sender, EventArgs e) {
            var progressaction = new Progress<float>();
            progressaction.ProgressChanged += progressaction_ProgressChanged;

            await myupdater.DownloadUpdateAsync(progressaction);

            lblver.Text = "V " + myupdater.CurrentVersion;
            lblstatus.Text = "Updated!";
            btnupdate.Enabled = false;
            lblstatus.ForeColor = Color.Green;
            btnplay.Enabled = true;

            if (!UpdateUpdater) return;
            try
            {
                if (new DirectoryInfo(UpdaterUpdatesPath).GetFiles().Any())
                {
                    Application.ApplicationExit += (o, args) => {
                        myupdater.ReplaceWithUpdate();
                    };
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to launch UpdaterUpdate", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void progressaction_ProgressChanged( object sender, float progress ) {
            progbar.Value = (int) progress;
        }
    }
}
