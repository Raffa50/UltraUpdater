using System;

namespace Aldrigos.UltraUpdater.Interfaces {
    public interface IUpdaterFactory {
        IUpdater CreateNew( Uri downloadsite, string applicationdirectory );
    }
}
