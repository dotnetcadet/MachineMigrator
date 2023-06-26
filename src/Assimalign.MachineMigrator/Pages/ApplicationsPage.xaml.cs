using Assimalign.MachineMigrator.Installers;
using Assimalign.MachineMigrator.ViewModel;

namespace Assimalign.MachineMigrator.Pages;

public partial class ApplicationsPage : ContentPage
{
	private readonly InstallerCollection installers = new();


	public ApplicationsPage()
	{
		InitializeComponent();

		Installers.ItemsSource = installers;
	}


	


	public void OnTypeAhead(object sender, TextChangedEventArgs @event)
	{
		var query = @event.NewTextValue;

		Installers.ItemsSource = installers.Where(installer =>
		{
			return string.IsNullOrEmpty(query) ? 
				true : 
				installer.Name.Contains(query, StringComparison.CurrentCultureIgnoreCase) || installer.Description.Contains(query, StringComparison.CurrentCultureIgnoreCase);
		});
	}
}