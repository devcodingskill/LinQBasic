using MyData;

namespace Helpers
{
    public static class EmployeeHelper
    {
        public static List<Employee> GetEmployees()
        {
            var departments = GetDepartments();

            var employees = new List<Employee>();
            var random = new Random();

            for (int i = 1; i <= 15; i++)
            {
                employees.Add(new Employee
                {
                    Id = i,
                    FirstName = $"FirstName{i}",
                    LastName = $"LastName{i}",
                    Department = departments[random.Next(departments.Count)],
                    IsManager = random.Next(2) == 0,
                    Salary = random.Next(50000, 150000),
                    ContactNumber = $"555-010{i:D3}"
                });
            }

            return employees;
        }
        public static List<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department { Id = 1, ShortName = "HR", LongName = "Human Resources", Location = "Building A" },
                new Department { Id = 2, ShortName = "IT", LongName = "Information Technology", Location = "Building B" },
                new Department { Id = 3, ShortName = "FIN", LongName = "Finance", Location = "Building C" }
            };
        }

        public static void PrintEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Department.ShortName} {employee.Salary}");
            }
        }
    }
}
