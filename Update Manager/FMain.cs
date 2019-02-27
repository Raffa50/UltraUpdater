using System;
using System.Windows.Forms;

namespace Aldrigo.UltraUpdater.Manager {
    public partial class FMain : Form {
        public FMain() {
            InitializeComponent();
        }

        private void BtMakeFirstRel_Click( object sender, EventArgs e ) {
            if( FBD.ShowDialog() != DialogResult.OK ) return;

            VersionManager.CreateFirstVersion( FBD.SelectedPath );
            MessageBox.Show( "Finish!", "Patch done", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void BtMakeUpdate_Click( object sender, EventArgs eventArgs ) {
            if( FBD.ShowDialog() != DialogResult.OK ) return;

            try {
                VersionManager.CreateUpdate( FBD.SelectedPath );
            }
            catch( InvalidOperationException e ) {
                MessageBox.Show( "Previous version doesn't exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            MessageBox.Show( "Finish!", "Patch done", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void BtCreateSettings_Click( object sender, EventArgs e ) {
            new FSettings().ShowDialog();
        }
    }
}
