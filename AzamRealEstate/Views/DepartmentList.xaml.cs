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
            CvDepartment.ItemsSource = departments;

    }
}