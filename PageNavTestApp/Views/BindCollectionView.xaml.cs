using PageNavTestApp.ViewModels;

namespace PageNavTestApp.Views;

public partial class BindCollectionView : ContentPage
{
	public BindCollectionView()
	{
		InitializeComponent();
		BindingContext = new CollectionViewModel();
	}
}