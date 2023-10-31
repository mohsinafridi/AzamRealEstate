using AzamRealEstate.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace AzamRealEstate.ViewModels
{
    public partial class AddDepartmentViewModel : ObservableObject
    {
       
        public AddDepartmentViewModel()
        {
            DepartmentDetails = new Department();
        }

        public Department DepartmentDetails { get; set; }


        [RelayCommand]
        public async void AddDepartment()
        {

            var departmentObj = this.DepartmentDetails;

            var response = await App.Database.CreateAsync(departmentObj);

            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Department Added", "Department Added Successfully", "OK");

                await Shell.Current.GoToAsync("..");
                // await Shell.Current.GoToAsync($"{nameof(DepartmentList)}");
            }
            {
                await Shell.Current.DisplayAlert("Department Not Saved", "Something went wrong with the Department Details", "OK");

            }
        }
    }
}
