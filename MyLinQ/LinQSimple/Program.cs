using Helpers;
using MyData;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        LinQForCar();
        //LinQForEmployee();
    }

    private static void LinQForCar()
    {
        var cars = Helpers.CarHelper.GetListOfCar();

        // LINQ Query
        var query = from car in cars
                    where car.Price > 30000
                    select car;
       CarHelper.PrintCars(query.ToList());

        // LINQ Method
        var query2 = cars.Where(c => c.Price > 30000);
    }
    private static void LinQForEmployee()
    {
        var employees = Helpers.EmployeeHelper.GetEmployees();

        // LINQ Query
        var query = from employee in employees
                    where employee.Salary > 90000
                    select employee;
        foreach (var employee in query)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Salary}");
        }
    }
}