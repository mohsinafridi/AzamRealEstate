namespace AzamRealEstate.Views;

public partial class AddDepartment : ContentPage
{
	public AddDepartment()
	{
		InitializeComponent();
	}


	 void BtnAddDepartment_Clicked(System.Object sender, System.EventArgs e)
	{
        string Name = EntDeptName.Text;

        //var response = await ApiService.RegisterEmployee(employee);
        //if (response)
        //{
        //    await DisplayAlert("", "Employee has been created", "Alright");
        //    await Navigation.PushModalAsync(new EmployeeListView());
        //}
        //else
        //{
        //    await DisplayAlert("", "Oops something went wrong", "Cancel");
        //}
    }
}