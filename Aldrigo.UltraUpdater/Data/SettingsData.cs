using System;

namespace Aldrigos.UltraUpdater.Data {
    [Serializable]
    public class SettingsData {
        public int FormWidth = 450, FormHeight = 320;
        public Uri SiteSplashUrl, DownloadSiteUrl;
        public string Shell;
        public MediaData Media;

        public SettingsData() {}

        public SettingsData( Uri downloadSiteUrl, Uri siteSplashUrl = null, string shell = null, MediaData media = null ) {
            DownloadSiteUrl = downloadSiteUrl;
            SiteSplashUrl = siteSplashUrl;
            Shell = shell;
            Media = media;
        }

        public SettingsData( Uri downloadSiteUrl, int formWidth, int formHeight, Uri siteSplashUrl = null, string shell = null, MediaData media = null ): this(downloadSiteUrl, siteSplashUrl, shell, media) {
            FormWidth = formWidth;
            FormHeight = formHeight;
        }
    }
}