using System.Text.Json;

namespace PageNavTestApp;

public partial class ResourcesExample : ContentPage
{
	public ResourcesExample()
	{
		InitializeComponent();
        
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
       await LoadMauiAsset();
        
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("Employee.json");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();
        var result = JsonSerializer.Deserialize<Employee>(contents);
    }
}

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}