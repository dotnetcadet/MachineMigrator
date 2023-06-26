using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.MachineMigrator.Installers;

public class VisualStudioInstaller : Installer
{
    public override Guid Id => throw new NotImplementedException();

    public override string Name => "Visual Studio";

    public override string Description => "";

    public override bool IsInstalled => throw new NotImplementedException();

    public override Task<InstallerResult> InstallAsync()
    {
        throw new NotImplementedException();
    }
}
