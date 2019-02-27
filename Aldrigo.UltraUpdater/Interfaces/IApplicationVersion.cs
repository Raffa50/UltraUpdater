namespace Aldrigos.UltraUpdater.Interfaces {
    public interface IApplicationVersion {
        int Version { get; }
        int CountFiles();
    }
}
