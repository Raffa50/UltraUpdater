namespace Aldrigos.UltraUpdater.Data {
    public enum MediaType { Audio, Video };

    public class MediaData {
        public MediaType Type;
        public string Path;

        public MediaData() {}

        public MediaData( MediaType mediaType, string relativePath ) {
            Type = mediaType;
            Path = relativePath;
        }
    }
}
