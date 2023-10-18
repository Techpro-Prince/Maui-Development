namespace PageNavTestApp;

public partial class CommandsDemo : ContentPage
{
	public CommandsDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Demo Page", "Hello World", "Ok");

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

        DisplayAlert("Demo Page", "Image Button Clicked!", "Ok");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Option Selected", $"selected:{e.Value}", "Ok");
    }

    private void Searching_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Searching Text", $"You Search {Searching.Text}", "Ok");

    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Swipe", "Swipe Text", "Ok");
    }
}