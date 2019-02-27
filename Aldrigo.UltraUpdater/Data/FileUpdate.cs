using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Aldrigos.UltraUpdater.Data {
    [Serializable]
    public class FileUpdate : AbstractFileUpdate
    {
        public string Md5 { get; }
        public string FullPath { get; }
        public DateTime LastEdit { get; } = DateTime.UtcNow;
        public int Version { get; }

        public FileUpdate() : base( "" ) {
            Version = 1;
        }

        public FileUpdate( string fullName, string md5, int version = 1 ) : base(Path.GetFileName(fullName)) {
            Version = version;
            FullPath = fullName;
            Md5 = md5;
        }

        public override bool Equals( AbstractFileUpdate o ) {
            var file = o as FileUpdate;
            if( file == null )
                return false;

            return Name.Equals( file.Name ) && Version == file.Version && Md5.Equals( file.Md5 );
        }

        public override int CountFiles() { return 1; }
    }
}
