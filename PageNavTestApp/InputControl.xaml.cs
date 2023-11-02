using System.Diagnostics;

namespace PageNavTestApp;

public partial class InputControl : ContentPage
{
	public InputControl()
	{
		InitializeComponent();
	}

    private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		resultSlider.Text=Slider1.Value.ToString();
    }
    private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if(Slider1 !=null)
        {
            resultSlider.Text=Stepper1.Value.ToString();
        }
    }

    private void UserTxt_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine(UserTxt.Text);
    }

    private void UserTxt_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(UserTxt.Text);
    }
}