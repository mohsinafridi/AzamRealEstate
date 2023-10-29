using AzamRealEstate.Services;

namespace AzamRealEstate.Views;

public partial class EmployeeListView : ContentPage
{
	public EmployeeListView()
	{
		InitializeComponent(); 
        GetEmployeeList();
    }

    private async void GetEmployeeList()
    {
        var employees = await ApiService.GetEmployees();
        if(employees.Any())
         CvEmployees.ItemsSource = employees;

    }

    void CvProperties_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        //var currentSelection = e.CurrentSelection.FirstOrDefault() as PropertyByCategory;
        //if (currentSelection == null) return;
        //Navigation.PushModalAsync(new PropertyDetailPage(currentSelection.Id));
        //((CollectionView)sender).SelectedItem = null;
    }
}