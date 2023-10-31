using AzamRealEstate.Views;
using AzamRealEstate.Views.Department;

namespace AzamRealEstate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(AddEmployee), typeof(AddEmployee));
        Routing.RegisterRoute(nameof(EmployeeListView), typeof(EmployeeListView));

        Routing.RegisterRoute(nameof(AddDepartment), typeof(AddDepartment));
        Routing.RegisterRoute(nameof(DepartmentList), typeof(DepartmentList));
        
    }
}