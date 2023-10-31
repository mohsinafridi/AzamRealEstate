using AzamRealEstate.ViewModels;

namespace AzamRealEstate.Views.Department;

public partial class CreateDepartment : ContentPage
{
    public AddDepartmentViewModel viewModel;
    public CreateDepartment(AddDepartmentViewModel model)
    {
        InitializeComponent();

        this.BindingContext = viewModel = model;
    }


}