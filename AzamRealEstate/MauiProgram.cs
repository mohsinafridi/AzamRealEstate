using AzamRealEstate.Database;
using AzamRealEstate.Services;
using AzamRealEstate.ViewModels;
using AzamRealEstate.Views;
using AzamRealEstate.Views.Department;
using Microsoft.Extensions.Logging;

namespace AzamRealEstate
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            // Services
            builder.Services.AddSingleton<AppDbContext>();
            builder.Services.AddSingleton<IDepartmentService, DepartmentService>();
            


            // Views
            builder.Services.AddSingleton<EmployeeListView>();
            builder.Services.AddTransient<AddEmployee>();

            builder.Services.AddSingleton<AddDepartment>();
            builder.Services.AddTransient<DepartmentDetailView>();
            builder.Services.AddTransient<DepartmentList>();

            // ViewModel
            builder.Services.AddTransient<AddDepartmentViewModel>();

            return builder.Build();
        }
    }
}