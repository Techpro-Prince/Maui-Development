using PageNavTestApp.Views;

namespace PageNavTestApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		MainPage = new BindCollectionView();
	}
}
