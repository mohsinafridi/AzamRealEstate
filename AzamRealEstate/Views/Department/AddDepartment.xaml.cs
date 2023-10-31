using AzamRealEstate.Services;
using AzamRealEstate.Models;
using AzamRealEstate.ViewModels;

namespace AzamRealEstate.Views.Department;

public partial class AddDepartment : ContentPage
{
	public AddDepartment()
	{
		InitializeComponent();
	}

    async void BtnAddDepartment_Clicked(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(EntDeptName.Text))
        {
            await DisplayAlert("", "Name is required", "Cancel");
        }

        var dept = new AzamRealEstate.Models.Department
        {
            Name = EntDeptName.Text
        };


        var response = await DeptService.CreateDepartment(dept);
        if (response)
        {
            await DisplayAlert("", "Department has been created", "Ok");
            await Navigation.PushModalAsync(new DepartmentList());
        }
        else
        {
            await DisplayAlert("", "Oops something went wrong", "Cancel");
        }
    }

    private async void TapDeptList_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new DepartmentList());
    }
    private async void TapCreateDept_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new CreateDepartment(new AddDepartmentViewModel()));
    }
    
}