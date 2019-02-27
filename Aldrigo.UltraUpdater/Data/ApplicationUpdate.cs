using System;
using System.IO;
using Aldrigos.UltraUpdater.Interfaces;

namespace Aldrigos.UltraUpdater.Data {
    [Serializable]
    public class ApplicationUpdate : IApplicationVersion {
        public DirectoryUpdate Root;

        public int Version { get; set; }
        public int CountFiles() { return Root.CountFiles(); }

        public ApplicationUpdate() { }

        public ApplicationUpdate( DirectoryInfo root ) {
            Root = DirectoryUpdate.GenerateDirectoryUpdate(root, root.FullName);
        }

        public ApplicationUpdate( DirectoryInfo root, int version ) : this( root ) {
            if( version < 0 ) throw new ArgumentOutOfRangeException("version must be >= 0");
            Version = version;
        }
    }
}
