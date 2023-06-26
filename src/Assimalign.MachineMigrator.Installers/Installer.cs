using Assimalign.MachineMigrator.Installers.Properties;

namespace Assimalign.MachineMigrator.Installers;

/// <summary>
/// 
/// </summary>
public abstract class Installer
{
    /// <summary>
    /// 
    /// </summary>
    public abstract Guid Id { get; }
    /// <summary>
    /// The name of the installer.
    /// </summary>
    public abstract string Name { get; }
    /// <summary>
    /// 
    /// </summary>
    public abstract string Description { get; }
    /// <summary>
    /// 
    /// </summary>
    public abstract bool IsInstalled { get; }
    /// <summary>
    /// 
    /// </summary>
    public virtual string Image { get; } = "blank.png";
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public abstract Task<InstallerResult> InstallAsync();
}