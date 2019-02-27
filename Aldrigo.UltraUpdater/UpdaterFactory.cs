using Aldrigos.UltraUpdater.Interfaces;
using System;

namespace Aldrigos.UltraUpdater {
    public sealed class UpdaterFactory : IUpdaterFactory {
        public IUpdater CreateNew( Uri downloadsite, string applicationdirectory ) {
            return new Updater(downloadsite, applicationdirectory);
        }
    }
}
