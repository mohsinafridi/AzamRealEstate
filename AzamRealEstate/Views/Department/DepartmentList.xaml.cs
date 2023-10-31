using AzamRealEstate.Models;
using AzamRealEstate.Services;

namespace AzamRealEstate.Views;

public partial class DepartmentList : ContentPage
{
    public DepartmentList()
    {
        InitializeComponent();
        GetDepartmentList();

    }

    private async void GetDepartmentList()
    {
        var departments = await DeptService.GetDepartments();
        if (departments.Any())
            CvDepartments.ItemsSource = departments;

    }

    private void CvDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var currentSelection = e.CurrentSelection.FirstOrDefault() as AzamRealEstate.Models.Department;

        if (currentSelection == null) return;

        Navigation.PushModalAsync(new DepartmentDetailView(currentSelection.Id));

        ((CollectionView)sender).SelectedItem = null;
    }
}