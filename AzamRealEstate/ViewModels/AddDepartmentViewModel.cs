using AzamRealEstate.Models;
using AzamRealEstate.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzamRealEstate.ViewModels
{
    public class AddDepartmentViewModel : ObservableObject
    {
        public Department DepartmentDetails { get; set; }
        public AddDepartmentViewModel()
        {
            DepartmentDetails = new Department();
        }

        public async void AddDepartment()
        {

            var departmentObj = this.DepartmentDetails;

            var response = await App.Database.CreateAsync(departmentObj);

            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Department Added", "Department Added Successfully", "OK");

                await Shell.Current.GoToAsync($"{nameof(DepartmentList)}");
            }
            {
                await Shell.Current.DisplayAlert("Department Not Saved", "Something went wrong with the Department Details", "OK");

            }
        }
    }
}
