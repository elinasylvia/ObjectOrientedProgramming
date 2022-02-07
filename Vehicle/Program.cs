using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle-tehtävä");

            Car car1 = new Car("Ford", "Focus", 2019, 18900, 1.4, "farmariauto", 5);
            car1.PrintInformation();
            Car car2 = new Car("Audi", "A4", 2014, 12500, 2.0, "sedan", 5);
            car2.PrintInformation();
            Car car3 = new Car("Volkswagen", "Touran", 2015, 8900, 1.6, "tila-auto", 5);
            Console.WriteLine(car3.ToString());
            Car car4 = new Car("Volkswagen", "Passat", 2020, 18900, 1.4, "farmariauto", 5);
                
            Console.WriteLine();
         
            if (car1.Equals(car2))
            {
                Console.WriteLine($"{car1.ToString()} ja {car2.ToString()} ovat samantyyppisiä autoja.");
            }
            else
            {
                Console.WriteLine($"{car1.ToString()} ja {car2.ToString()} eivät ole samantyyppisiä autoja.");

            }
            if (car4.Equals(car1))
            {
                Console.WriteLine($"{car4.ToString()} ja {car1.ToString()} ovat samantyyppisiä autoja.");
            }
            else
            {
                Console.WriteLine($"{car4.ToString()} ja {car1.ToString()} eivät ole samantyyppisiä autoja.");

            }
            Console.WriteLine();

            Truck truck1 = new Truck("Volvo", "FH-16", 2021, 250000, 4.0, "kuorma-auto", 2, 3500, 0.003);
            truck1.PrintInformation();
            Console.WriteLine($"Polttoaineen kulutus: {truck1.CalculateConsumption()} l/100km");
            Truck truck2 = new Truck("Scania", "L-series", 2005, 25000, 4.5, "kuorma-auto", 2, 5500, 0.004);
            truck2.PrintInformation();
            Console.WriteLine($"Polttoaineen kulutus: {truck2.CalculateConsumption()} l/100km");

            Car car5 = (Car)truck2;
            car5.PrintInformation();

        }
    }
}
