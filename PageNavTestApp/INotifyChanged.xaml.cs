namespace PageNavTestApp;

public partial class INotifyChanged : ContentPage
{
	Models.Employee emp = new Models.Employee();
	public INotifyChanged()
	{
		InitializeComponent();
		emp=new Models.Employee()
		{
			Id = 1,
			Name="Shakti Singh Tanwar",
			Age=32,
			Salary=32000,
		};
		BindingContext=emp;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		emp.Id=2;
		emp.Name="Prince Singh";
		emp.Age=32;
		emp.Salary=45000;
    }
}