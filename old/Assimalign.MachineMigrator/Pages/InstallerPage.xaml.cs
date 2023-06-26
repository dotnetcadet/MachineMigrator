using Assimalign.MachineMigrator.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Assimalign.MachineMigrator;

using Assimalign.MachineMigrator.Installers;

public partial class InstallerPage : ContentPage
{
	public InstallerPage()
	{
		InitializeComponent();
        BindingContext = new MonkeysViewModel();
    }
}