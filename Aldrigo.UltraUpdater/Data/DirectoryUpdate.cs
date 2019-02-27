using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aldrigos.UltraUpdater.Data {
    [Serializable]
    public class DirectoryUpdate : AbstractFileUpdate {
        private readonly List<AbstractFileUpdate> _contents = new List<AbstractFileUpdate>();

        [JsonIgnore]
        public IEnumerable<AbstractFileUpdate> Contents => _contents;

        private DirectoryUpdate() : base( "" ) {}

        private DirectoryUpdate(string name) : base(name) {}

        public static DirectoryUpdate GenerateDirectoryUpdate(DirectoryInfo dir, string initialDirectoryPath)
        {
            if (initialDirectoryPath.Last() != Path.DirectorySeparatorChar)
                initialDirectoryPath += Path.DirectorySeparatorChar;

            var du= new DirectoryUpdate(dir.Name);
            //need to exclude ultraupdater version.json
            foreach (var file in dir.GetFiles().Where(f => f.Name != "version.json" && dir.FullName != initialDirectoryPath))
            {
                var relativePath = file.FullName.Replace(initialDirectoryPath, "");
                du._contents.Add(new FileUpdate(relativePath, Utils.GetFileMd5(file.FullName)));
            }

            foreach (var subdir in dir.GetDirectories())
            {
                du._contents.Add( GenerateDirectoryUpdate(subdir, initialDirectoryPath) );
            }

            return du;
        }

        public override int CountFiles() {
           return _contents.Sum( file => file.CountFiles() );
        }

        public override bool Equals( AbstractFileUpdate o ) {
            var file = o as DirectoryUpdate;
            return file != null && file._contents.Equals( _contents );
       }

        public DirectoryUpdate GetSubDir( string dirname ) {
            return _contents.OfType< DirectoryUpdate >().FirstOrDefault( dir => dir.Name.Equals( dirname ) );
        }
    }
}
