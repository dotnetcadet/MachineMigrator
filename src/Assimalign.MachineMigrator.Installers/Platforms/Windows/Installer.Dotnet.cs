using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.MachineMigrator.Installers;

public class DotnetInstaller : Installer
{
    public override Guid Id => new Guid("4e4591c8-6d16-4774-9a40-4b04cbbfd992");
    public override string Name => ".NET Runtime";
    public override string Description => "Install all or selected .NET Runtimes.";
    public override bool IsInstalled => false;
    public override Task<InstallerResult> InstallAsync()
    {
        throw new NotImplementedException();
    }
}
