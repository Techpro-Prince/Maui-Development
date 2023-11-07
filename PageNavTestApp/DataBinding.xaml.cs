namespace PageNavTestApp;

public partial class DataBinding : ContentPage
{
	public DataBinding()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		PageNavTestApp.Models.Employee employee = new PageNavTestApp.Models.Employee()
		{ 
			Id=1,
			Name="Prince Singh",
			Age=32,
			Salary=22000,
		};
		Binding empBinding= new Binding();
		empBinding.Source = employee;
		empBinding.Path="Name";
		employeLbl.SetBinding(Label.TextProperty, empBinding);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        PageNavTestApp.Models.Employee employee = new PageNavTestApp.Models.Employee()
        {
            Id=1,
            Name="Sumit Yadav",
            Age=32,
            Salary=52000,
        };
		BindingContext=employee;

    }
}