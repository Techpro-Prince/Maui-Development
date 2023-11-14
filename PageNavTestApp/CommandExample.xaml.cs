using PageNavTestApp.ViewModels;

namespace PageNavTestApp;

public partial class CommandExample : ContentPage
{
	public CommandExample()
	{
		InitializeComponent();
		BindingContext = new CommandExampleVM();
	}
}