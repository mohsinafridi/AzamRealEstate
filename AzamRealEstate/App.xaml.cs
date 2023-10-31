using AzamRealEstate.Database;

namespace AzamRealEstate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new CreateDepartment(new ViewModels.AddDepartmentViewModel());
            MainPage = new AppShell();
        }

        public static AppDbContext Database { get; private set; }
    }
}