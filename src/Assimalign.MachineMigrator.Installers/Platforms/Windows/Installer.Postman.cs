using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assimalign.MachineMigrator.Installers.Properties;

namespace Assimalign.MachineMigrator.Installers;

internal class PostmanInstaller : Installer
{
    public override Guid Id => new Guid("5028afbf-37d0-493d-b13d-e44468427b67");
    public override string Name => "Postman";
    public override string Description => "Installs Postman API tool.";
    public override bool IsInstalled => false;
    public override string Image => "postman.png";

    public override Task<InstallerResult> InstallAsync()
    {
        throw new NotImplementedException();
    }
}
