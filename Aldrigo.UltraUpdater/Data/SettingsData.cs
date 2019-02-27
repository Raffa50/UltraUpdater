using System;

namespace Aldrigos.UltraUpdater.Data {
    [Serializable]
    public class SettingsData {
        public int FormWidth = 450, FormHeight = 320;
        public string SiteSplashUrl, DownloadSiteUrl, Shell;
        public MediaData Media;

        public SettingsData() {}

        public SettingsData( string downloadSiteUrl, string siteSplashUrl = null, string shell = null, MediaData media = null ) {
            DownloadSiteUrl = downloadSiteUrl;
            SiteSplashUrl = siteSplashUrl;
            Shell = shell;
            Media = media;
        }

        public SettingsData( string downloadSiteUrl, int formWidth, int formHeight, string siteSplashUrl = null, string shell = null, MediaData media = null ): this(downloadSiteUrl, siteSplashUrl, shell, media) {
            FormWidth = formWidth;
            FormHeight = formHeight;
        }
    }
}