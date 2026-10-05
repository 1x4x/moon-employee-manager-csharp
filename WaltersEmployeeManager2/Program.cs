using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaltersEmployeeManager2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.Write("Name (or press Enter to quit): ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                Employee employee = new Employee
                {
                    Name = name,
                    Salary = salary
                };

                employees.Add(employee);
            }

            Console.WriteLine();
            Console.WriteLine("EMPLOYEES:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary:C}");
            }
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
}
