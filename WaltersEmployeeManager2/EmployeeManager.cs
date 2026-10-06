using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaltersEmployeeManager2
{
    public class EmployeeManager
    {
        private readonly List<Employee> employees = new List<Employee>();

        public void Create(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}
