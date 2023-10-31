using AzamRealEstate.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzamRealEstate.Services
{
    public class DepartmentService : IDepartmentService
    {
        public SQLiteAsyncConnection _dbConnection;

        private async Task SetupDatabase()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MainDatabase.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Department>();
            }
        }
        public async Task<int> AddDepartment(Department department)
        {
            await SetupDatabase();
            return await _dbConnection.InsertAsync(department);
        }

        public async Task<int> DeleteDepartment(Department department)
        {
            await SetupDatabase();
            return await _dbConnection.DeleteAsync(department);
        }

        public async Task<List<Department>> GetDepartmentsList()
        {
            await SetupDatabase();
            var departmentlist = await _dbConnection.Table<Department>().ToListAsync();
            return departmentlist;
        }

        public async Task<int> UpdateDepartment(Department department)
        {
            await SetupDatabase();
            return await _dbConnection.UpdateAsync(department);
        }
    }
}
