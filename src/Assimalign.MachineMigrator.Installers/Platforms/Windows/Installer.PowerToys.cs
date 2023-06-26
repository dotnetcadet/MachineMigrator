using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.MachineMigrator.Installers;

public class PowerToysInstaller : Installer
{
    public override Guid Id => new Guid("b400b0c5-4d9c-4540-9012-4c71be416ef0");
    public override string Name => "Power Toys";
    public override string Description => "Installs Windows Power Toys";
    public override bool IsInstalled => false;
    public override string Image => "powertoys.png";

    public override Task<InstallerResult> InstallAsync()
    {
        throw new NotImplementedException();
    }
}
