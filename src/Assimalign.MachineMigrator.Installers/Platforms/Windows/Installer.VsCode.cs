using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.MachineMigrator.Installers;

public class VsCodeInstaller : Installer
{
    public override Guid Id => throw new NotImplementedException();

    public override string Name => "VS Code";

    public override string Description => "";

    public override bool IsInstalled => throw new NotImplementedException();

    public override string Image => "vscode.png";

    public override Task<InstallerResult> InstallAsync()
    {
        throw new NotImplementedException();
    }
}
