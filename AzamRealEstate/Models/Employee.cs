using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzamRealEstate.Models
{
    public class Employee
    {

        public string Name { get; set; }
        public string FatherName { get; set; }

        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DeparmentName { get; set; }
        public string EmployeeType { get; set; }
        public string Facility { get; set; }
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }
        public int TitleId { get; set; }
    }
}
