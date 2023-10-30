using AzamRealEstate.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace AzamRealEstate.Services
{
    public static class ApiService
    {

        public static async Task<List<Employee>> GetEmployees()
        {
            var httpClient = new HttpClient();
            
            var response = await httpClient.GetStringAsync(AppSettings.ApiUrl + "api/employee");
            
            return JsonConvert.DeserializeObject<List<Employee>>(response);
        }

        public static async Task<bool> RegisterEmployee(Employee employee)
        {

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(employee);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(AppSettings.ApiUrl + "api/employee/AddEmployee", content);
            if (!response.IsSuccessStatusCode) return false;
            return true;
        }

        

    }
}
