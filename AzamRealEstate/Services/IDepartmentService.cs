using AzamRealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzamRealEstate.Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartmentsList();


        Task<int> AddDepartment(Department department);


        Task<int> DeleteDepartment(Department department);

        Task<int> UpdateDepartment(Department department);
    }
}
