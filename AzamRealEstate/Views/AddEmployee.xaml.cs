using AzamRealEstate.Models;
using AzamRealEstate.Services;

namespace AzamRealEstate.Views;

public partial class AddEmployee : ContentPage
{
    public AddEmployee()
    {
        InitializeComponent();
    }

    private void pkdepts_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedOption = pkdepts.SelectedItem.ToString();
        // Do something with the selected option 
    }
    async void BtnAddEmployee_Clicked(System.Object sender, System.EventArgs e)
    {
        string Name = EntName.Text;
        string FathName = EntFatherName.Text;
        string Email = EntEmail.Text;
        DateTime JoiningDate = DpJoingDate.Date;
        DateTime DateOfBirth = DpDOB.Date;
       // string deptName = pkdepts.SelectedItem.ToString();
        string EmpType = pkEmpTyp.SelectedItem.ToString();
        decimal Salary = Convert.ToDecimal(EntSalary.Text);

        // Save Data to Employee Table in Database.

        var employee = new Employee
        {
            Name = Name,
            FatherName = FathName,
            Email = Email,
            JoiningDate = JoiningDate,
            DateOfBirth = DateOfBirth,
            DepartmentId = 2,//deptName,
            TitleId = 2,
            EmployeeType = EmpType,
            Salary = Salary
        };

        var response = await ApiService.RegisterEmployee(employee);
        if (response)
        {
            await DisplayAlert("", "Employee has been created", "Alright");
            await Navigation.PushModalAsync(new EmployeeListView());
        }
        else
        {
            await DisplayAlert("", "Oops something went wrong", "Cancel");
        }
    }


}