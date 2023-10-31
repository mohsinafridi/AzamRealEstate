using AzamRealEstate.Views;

namespace AzamRealEstate.Controls;

public partial class CustomFlyoutContent : ContentView
{
	public CustomFlyoutContent()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AppShell());
        //await Shell.Current.DisplayAlert("Menu item tapped", "This item was tapped from the custom flyout content", "Ok");
    }
}