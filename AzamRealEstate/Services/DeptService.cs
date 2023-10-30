﻿using AzamRealEstate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzamRealEstate.Services
{
    public static class DeptService
    {
        public static async Task<bool> CreateDepartment(Employee employee)
        {

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(employee);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(AppSettings.ApiUrl + "api/department/add-department", content);
            if (!response.IsSuccessStatusCode) return false;
            return true;
        }

        public static async Task<List<Department>> GetDepartments()
        {

            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync(AppSettings.ApiUrl + "api/department");

            return JsonConvert.DeserializeObject<List<Department>>(response);
        }
    }
}