using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimalign.MachineMigrator.Installers;

public sealed class InstallerCollection : List<Installer>
{
#if WINDOWS
    public InstallerCollection()
    {
        Add(new PowerToysInstaller());
        Add(new DotnetInstaller());
        Add(new PostmanInstaller());
        Add(new VsCodeInstaller());
        Add(new LinqPadInstaller());
        Add(new ObsidianInstaller());
        Add(new VisualStudioInstaller());
    }
#endif
}
