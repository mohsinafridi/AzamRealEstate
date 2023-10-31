using AzamRealEstate.Views;
using AzamRealEstate.Views.Department;

namespace AzamRealEstate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(CreateDepartment), typeof(CreateDepartment));
        Routing.RegisterRoute(nameof(AddDepartment), typeof(AddDepartment));
        Routing.RegisterRoute(nameof(DepartmentList), typeof(DepartmentList));
        
    }
}