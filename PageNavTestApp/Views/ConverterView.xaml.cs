using PageNavTestApp.ViewModels;

namespace PageNavTestApp.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}