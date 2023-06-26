namespace Assimalign.MachineMigrator.Installers;

// All the code in this file is included in all platforms.
public abstract partial class Installer
{


    public abstract Task<InstallerResult> InstallAsync();
}