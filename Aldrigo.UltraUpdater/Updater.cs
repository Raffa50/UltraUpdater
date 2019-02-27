using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Aldrigos.UltraUpdater.Data;
using Aldrigos.UltraUpdater.Interfaces;
using Newtonsoft.Json;

namespace Aldrigos.UltraUpdater {
    public class Updater : IUpdater {
        private readonly ApplicationUpdate _application;

        public string UpdaterCacheDir => Path.Combine(ApplicationDirectory, ".updatercache");

        public string ApplicationDirectory { get; }
        public Uri DownloadSite { get; }
        public int CurrentVersion => _application.Version;

        private int _NumDownloadedFiles, _NumAllFiles;

        private string NewVersionJson => Path.Combine(UpdaterCacheDir, "version.json");

        public Updater( Uri downloadsite, string applicationdirectory ) {
            DownloadSite = downloadsite ?? throw new ArgumentNullException(nameof(downloadsite));
            ApplicationDirectory = applicationdirectory ?? throw new ArgumentNullException(nameof(applicationdirectory));

            if( ApplicationDirectory.Last() != Path.DirectorySeparatorChar ) 
                ApplicationDirectory += Path.DirectorySeparatorChar;

            string versionPath = Path.Combine(ApplicationDirectory, "version.json");
            if ( !File.Exists(versionPath) ) {
                _application = new ApplicationUpdate( new DirectoryInfo(ApplicationDirectory), 0 );
                return;
            }

            var updateJson = File.ReadAllText(versionPath);
            _application = JsonConvert.DeserializeObject<ApplicationUpdate>(updateJson);
        }

        public async Task<IApplicationVersion> GetLatestVersion() {
            if (!Directory.Exists(UpdaterCacheDir))
                Directory.CreateDirectory(UpdaterCacheDir);

            using (var wc = new WebClient())
            {
                await wc.DownloadFileTaskAsync(new Uri(DownloadSite, "version.json"), NewVersionJson);
            }

            var updateJson = File.ReadAllText(NewVersionJson);
            return JsonConvert.DeserializeObject<ApplicationUpdate>(updateJson);
        }

        public bool IsUpdated(IApplicationVersion previousVersion) {
            return CurrentVersion >= previousVersion.Version;
        }

        public async Task DownloadUpdateAsync( IProgress<float> fileDownloaded = null, CancellationToken cancellationToken = default ) {
            var lastversion = GetLatestVersion().Result as ApplicationUpdate;
            Debug.Assert(lastversion != null);

            if (CurrentVersion >= lastversion.Version) return;
            _NumDownloadedFiles = 0;
            _NumAllFiles = lastversion.CountFiles();

            var tasks = lastversion.Root.Contents.Select(file =>
                DownloadFile(file, _application.Root, UpdaterCacheDir, DownloadSite, fileDownloaded,
                    cancellationToken));

            await Task.WhenAll(tasks);
        }

        public void ReplaceWithUpdate(string bootApp = null)
        {
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = $"xcopy /s \"{UpdaterCacheDir}\" \"{ApplicationDirectory}\" & RMDIR \"{UpdaterCacheDir}\" /S /Q",
                Verb = "runas"
            };
            var process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();
        }

        public async Task<IEnumerable<DirectoryUpdate>> IntegrityCheckAsync(CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<DirectoryUpdate> CheckFile(ApplicationUpdate update, AbstractFileUpdate fl, string path, string webPath,
            CancellationToken cancellation)
        {
            throw new NotImplementedException();
            //if (fl is FileUpdate)
            //{
            //    var file = (FileUpdate) fl;
            //    var currentFile = new FileUpdate(file.FullPath, file.Version);
            //    if (!file.Equals(currentFile))
            //        await downloadfile...;
            //}
        }

        public async Task IntegrityCheckWithFixAsync(IProgress<float> progress = null, CancellationToken cancellation = default)
        {
            var corruptedFiles = await IntegrityCheckAsync(cancellation);
            throw new NotImplementedException();
        }

        public Task ReDownload(IEnumerable<DirectoryUpdate> files, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        private async Task DownloadFile( AbstractFileUpdate fl, DirectoryUpdate prevVerDir, string path, Uri webpath, IProgress<float> fileDownloaded, CancellationToken cancellationToken ) {
            if( cancellationToken.IsCancellationRequested )
                return;

            if( fl is FileUpdate ) {
                if (prevVerDir == null || !prevVerDir.Contents.Contains(fl))
                {
                    using(var wc = new WebClient()) { 
                        await wc.DownloadFileTaskAsync(new Uri(webpath, fl.Name), Path.Combine(path, fl.Name));
                    }
                }

                fileDownloaded?.Report( 100f * _NumDownloadedFiles++ / _NumAllFiles );
            }
            else {
                var dir = fl as DirectoryUpdate;
                Debug.Assert( dir != null );

                string dirPath = Path.Combine(path, dir.Name);
                if( !Directory.Exists(dirPath) )
                    Directory.CreateDirectory(dirPath);

                var tasks= dir.Contents.Select(file =>
                    DownloadFile(file, prevVerDir.GetSubDir(dir.Name), dirPath, new Uri(webpath, dir.Name),
                        fileDownloaded, cancellationToken));

                await Task.WhenAll(tasks);
            }
        }
    }
}
