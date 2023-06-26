using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Assimalign.MachineMigrator.ViewModel;

using Assimalign.MachineMigrator.Installers;

public class InstallerViewModel : INotifyPropertyChanged
{
    private static readonly IEnumerable<Installer> installers = new InstallerCollection();
    private IEnumerable<Installer> it = installers;



    public ICommand Search => new Command<string>((string query) =>
    {
        it = installers.Where(installer =>
        {
            if (string.IsNullOrEmpty(query))
            {
                return true;
            }
            return installer.Name.Contains(query) || installer.Description.Contains(query);
        });
    });


    public IEnumerable<Installer> Installers
    {
        get => installers;
        set
        {
            it = value;
            NotifyPropertyChanged();
        }
    }



    protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
