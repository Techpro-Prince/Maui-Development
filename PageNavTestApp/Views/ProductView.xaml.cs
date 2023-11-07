using PageNavTestApp.ViewModels;

namespace PageNavTestApp.Views;

public partial class ProductView : ContentPage
{
	public ProductView()
	{
		InitializeComponent();
        BindingContext= new ProductViewModel();
	}
}