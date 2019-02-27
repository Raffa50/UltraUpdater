using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Aldrigos.UltraUpdater.Data;

namespace Aldrigos.UltraUpdater.Interfaces {
    public interface IUpdater {
        string ApplicationDirectory { get; }
        Uri DownloadSite { get; }
        int CurrentVersion { get; }

        /// <summary>
        /// Get latest version from web
        /// </summary>
        /// <returns></returns>
        Task< IApplicationVersion > GetLatestVersion();

        bool IsUpdated( IApplicationVersion previousVersion );
        
        /// <summary>
        /// Download a new update async
        /// </summary>
        /// <param name="fileDownloaded">reports the progress in percentage</param>
        /// <returns></returns>
        Task DownloadUpdateAsync( IProgress< float > fileDownloaded = null, CancellationToken cancellationToken = default );

        /// <summary>
        /// Copies files from download cache to application
        /// </summary>
        void ReplaceWithUpdate(string bootApplication = null);

        /// <summary>
        /// Performs integrity check on current version
        /// </summary>
        /// <param name="currentVersion"></param>
        /// <returns></returns>
        Task<IEnumerable< DirectoryUpdate >> IntegrityCheckAsync(CancellationToken cancellation = default);

        /// <summary>
        /// Performs integrity check, then replace corrupted files
        /// </summary>
        /// <param name="currentVersion"></param>
        /// <param name="cancellation"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        Task IntegrityCheckWithFixAsync(IProgress<float> progress = null, CancellationToken cancellationToken = default);

        Task ReDownload( IEnumerable< DirectoryUpdate > files, CancellationToken cancellation = default );
    }
}
