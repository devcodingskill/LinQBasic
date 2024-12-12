using MyData;

namespace Helpers
{
    public static class CarHelper
    {
        public static List<Car> GetListOfCar()
        {
            return new List<Car>
            {
                new Car { Make = "Toyota", Model = "Camry", Year = 2018, Price = 25000, Color = "Red", VIN = "1234567890" },
                new Car { Make = "Toyota", Model = "Corolla", Year = 2018, Price = 20000, Color = "Blue", VIN = "1234567891" },
                new Car { Make = "Toyota", Model = "Prius", Year = 2018, Price = 30000, Color = "Green", VIN = "1234567892" },
                new Car { Make = "Toyota", Model = "RAV4", Year = 2018, Price = 35000, Color = "Yellow", VIN = "1234567893" },
                new Car { Make = "Toyota", Model = "Highlander", Year = 2018, Price = 40000, Color = "Black", VIN = "1234567894" },
                new Car { Make = "Toyota", Model = "4Runner", Year = 2018, Price = 45000, Color = "White", VIN = "1234567895" },
                new Car { Make = "Toyota", Model = "Tacoma", Year = 2018, Price = 50000, Color = "Silver", VIN = "1234567896" },
                new Car { Make = "Toyota", Model = "Tundra", Year = 2018, Price = 55000, Color = "Gray", VIN = "1234567897" },
                new Car { Make = "Toyota", Model = "Sienna", Year = 2018, Price = 60000, Color = "Brown", VIN = "1234567898" },
                new Car { Make = "Toyota", Model = "Yaris", Year = 2018, Price = 65000, Color = "Orange", VIN = "1234567899" }
            };
        }
    }
}
