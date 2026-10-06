using System;

namespace WaltersEmployeeManager2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            while (true)
            {
                // Get name
                string name;

                while (true)
                {
                    Console.Write("Name (or press Enter to quit): ");
                    name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine();
                        Console.WriteLine("EMPLOYEES:");
                        var employees = employeeManager.GetAllEmployees();
                        foreach (var item in employees)
                        {
                            Console.WriteLine($"Name: {item.Name}, Salary: {item.Salary:C}");
                        }
                        return;
                    }

                    break;
                }

                // Get salary
                decimal salary;

                while (true)
                {
                    Console.Write("Salary: ");
                    string salaryInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(salaryInput))
                    {
                        Console.WriteLine("Salary is required.");
                        continue;
                    }

                    if (!decimal.TryParse(salaryInput, out salary))
                    {
                        Console.WriteLine("Salary must be a number.");
                        continue;
                    }

                    if (salary < 0)
                    {
                        Console.WriteLine("Salary must be 0 or higher.");
                        continue;
                    }

                    break;
                }

                Employee employee = new Employee
                {
                    Name = name,
                    Salary = salary
                };

                employeeManager.Create(employee);

                Console.WriteLine("Employee added.");
                Console.WriteLine();
            }
        }
    }
}
