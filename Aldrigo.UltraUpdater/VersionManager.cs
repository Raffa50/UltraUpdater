using System;
using System.IO;
using Aldrigos.UltraUpdater.Data;
using Newtonsoft.Json;

namespace Aldrigos.UltraUpdater {
    public static class VersionManager {
        private static void CreateVersion( string appDir, int version, string versionfilename ) {
            var myapplication = new ApplicationUpdate( new DirectoryInfo( appDir ), version );

            using( var writer = new StreamWriter( appDir + Path.DirectorySeparatorChar + versionfilename + ".json" ) ) {
                writer.Write( JsonConvert.SerializeObject(myapplication) );
            }
        }

        public static void CreateFirstVersion( string appDir ) {
            if( appDir == null )
                throw new ArgumentNullException( nameof(appDir) );
            CreateVersion( appDir, 1, "version" );
        }

        public static void CreateUpdate( string appDir ) {
            if( !File.Exists(appDir + Path.DirectorySeparatorChar + "version.json") )
                throw new InvalidOperationException("Previous version doesn't exist");

            var versionJson = File.ReadAllText(appDir + Path.DirectorySeparatorChar + "version.json");
            int currentversion = JsonConvert.DeserializeObject<ApplicationUpdate>(versionJson).Version;

            CreateVersion(appDir, currentversion +1, "newversion");
        }
    }
}
