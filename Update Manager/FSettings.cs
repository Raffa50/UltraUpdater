using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Aldrigo.UltraUpdater.Data;

namespace Aldrigo.UltraUpdater.Manager {
    public partial class FSettings : Form {
        public FSettings() {
            InitializeComponent();
        }

        private void btMakeSettings_Click( object sender, EventArgs e ) {
            if( Fbd.ShowDialog() != DialogResult.OK ) return;

            var splashurl = (TbSplashUrl.Text.Length > 0) ? TbSplashUrl.Text : null;
            var shell = ( TbShell.Text.Length > 0 ) ? TbShell.Text : null;

            MediaData media = null;
            if( !RbNoMedia.Checked ) {
                media = new MediaData( (RbMediaAudio.Checked) ? MediaType.Audio : MediaType.Video,
                    TbMediaPath.Text );
            }

            var s = new SettingsData( TbDownloadUrl.Text, (int)NuFormWidth.Value, (int)NuFormHeight.Value,
                splashurl, shell, media );

            var serializer = new XmlSerializer( typeof( SettingsData ) );
            using( var writer = new StreamWriter( Fbd.SelectedPath + Path.DirectorySeparatorChar + "settings.xml" ) ) {
                serializer.Serialize( writer, s );
            }

            MessageBox.Show( "Completed!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
