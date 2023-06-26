using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.MachineMigrator.Installers;

public class ObsidianInstaller : Installer
{
    public override Guid Id => throw new NotImplementedException();

    public override string Name => "Obsidian";

    public override string Description => "";

    public override bool IsInstalled => throw new NotImplementedException();

    public override Task<InstallerResult> InstallAsync()
    {
        throw new NotImplementedException();
    }
}
