using AzamRealEstate.Database;
using AzamRealEstate.Views.Department;

namespace AzamRealEstate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Database = new AppDbContext();

            MainPage = new AddDepartment();
        }

        public static AppDbContext Database { get; private set; }
    }
}