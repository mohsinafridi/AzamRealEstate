using AzamRealEstate.Models;
using AzamRealEstate.Services;

namespace AzamRealEstate.Views;

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

        var dept = new Department
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
}