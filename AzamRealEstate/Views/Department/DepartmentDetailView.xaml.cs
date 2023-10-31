using AzamRealEstate.Services;

namespace AzamRealEstate.Views;

public partial class DepartmentDetailView : ContentPage
{
	// private int departmentId;
	public DepartmentDetailView(int departmentId)
	{
		InitializeComponent();
		GetDepartmentById(departmentId);
	}

	private async void GetDepartmentById(int departmentId)
	{
        var department = await DeptService.GetDepartment(departmentId);

		if (department is not null)
		{
           LblName.Text = department.Name;
        }
            
    }
}