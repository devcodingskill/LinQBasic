using MyData;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
       
        var cars = Helpers.CarHelper.GetListOfCar();

        // LINQ Query
        var query = from car in cars
                    where car.Price > 30000
                    select car;
        foreach (var car in query)
        {
            Console.WriteLine($"{car.Make} {car.Model} {car.Price}");
        }
    }
}