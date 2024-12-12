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
        var query3 = cars.Where(c => c.Price > 30000).Select(c => new { c.Make, c.Model, c.Price });
        var query4 = cars.FindAll(c => c.Model =="Prius");
        var query5 = cars.Exists(c => c.Model == "Prius");
        var query6 = cars.All(c => c.Price > 30000);
        var query7 = cars.Any(c => c.Price > 30000);
        var query8 = cars.Count(c => c.Price > 30000);
        var query9 = cars.Max(c => c.Price);
        var query10 = cars.Min(c => c.Price);
        var query11 = cars.Sum(c => c.Price);
        var query12 = cars.Average(c => c.Price);
        var query13 = cars.OrderBy(c => c.Price);
        var query14 = cars.OrderByDescending(c => c.Price);
        var query15 = cars.Skip(2).Take(3);
        var query16 = cars.SkipWhile(c => c.Price < 30000);
        var query17 = cars.TakeWhile(c => c.Price < 30000);
        var query18 = cars.GroupBy(c => c.Make);
        var query19 = cars.ToDictionary(c => c.VIN);
        var query20 = cars.ToLookup(c => c.Make);
        var query21 = cars.SelectMany(c => c.Model);
        var query22 = cars.Concat(cars);
        var query23 = cars.Intersect(cars);
        var query24 = cars.Except(cars);
        var query25 = cars.Union(cars);
        var query26 = cars.Distinct();        
        var query28 = cars.First();
        var query29 = cars.FirstOrDefault();
        var query30 = cars.Last();
        var query31 = cars.LastOrDefault();
        var query32 = cars.Single(c => c.Model == "Prius");
    }
    private static void LinQForEmployee()
    {
        var employees = Helpers.EmployeeHelper.GetEmployees();

        // LINQ Query
        var query = from employee in employees
                    where employee.Salary > 90000
                    select employee;
       Helpers.EmployeeHelper.PrintEmployees(query.ToList());

        // LINQ Method
        var query2 = employees.Where(e => e.Salary > 90000);
        var query3 = employees.Where(e => e.Salary > 90000).Select(e => new { e.FirstName, e.LastName, e.Salary });
        var query4 = employees.FindAll(e => e.Department.ShortName == "HR");
        var query5 = employees.Exists(e => e.Department.ShortName == "HR");
        var query6 = employees.All(e => e.Salary > 90000);
        var query7 = employees.Any(e => e.Salary > 90000);
        var query8 = employees.Count(e => e.Salary > 90000);
        var query9 = employees.Max(e => e.Salary);
        var query10 = employees.Min(e => e.Salary);
        var query11 = employees.Sum(e => e.Salary);
        var query12 = employees.Average(e => e.Salary);
        var query13 = employees.OrderBy(e => e.Salary);
        var query14 = employees.OrderByDescending(e => e.Salary);
        var query15 = employees.Skip(2).Take(3);
        var query16 = employees.SkipWhile(e => e.Salary < 90000);
        var query17 = employees.TakeWhile(e => e.Salary < 90000);
        var query18 = employees.GroupBy(e => e.Department.ShortName);
        var query19 = employees.ToDictionary(e => e.Id);
        var query20 = employees.ToLookup(e => e.Department.ShortName);
        var query21 = employees.SelectMany(e => e.ContactNumber);
        var query22 = employees.Concat(employees);
        var query23 = employees.Intersect(employees);
        var query24 = employees.Except(employees);
        var query25 = employees.Union(employees);
        var query26 = employees.Distinct();
        var query28 = employees.First();
        var query29 = employees.FirstOrDefault();
        var query30 = employees.Last();
        var query31 = employees.LastOrDefault();
        var query32 = employees.Single(e => e.Department.ShortName == "HR");
    }
}