using AzamRealEstate.Views;

namespace AzamRealEstate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}