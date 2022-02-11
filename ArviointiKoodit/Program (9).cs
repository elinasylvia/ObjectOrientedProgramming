using System;

namespace VehicleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä-Vehicle\n");

            Car car1 = new Car("BMW", "E30", 1987, 50000, "2.3L", "Bensiini", 3);
            Car car2 = new Car("Mercedez-Benz", "C63 AMG", 2015, 70000, "4.0L", "Bensiini", 5);
            //Vehicle vehicle1 = new Vehicle("Nissan", "Micra", 1999, 500);

            Console.Write("Auto 1: ");
            car1.PrintInformation();

            Console.Write("Auto 2: ");
            car2.PrintInformation();
            //vehicle1.PrintInformation();

            Car car3 = new Car("Audi", "A5", 2012, 12000, "3.0L", "Diesel", 3);

            Console.Write("Auto 3: ");
            Console.WriteLine(car3.ToString());

            if (car1.Equals(car3))
            {
                Console.WriteLine($"Autoissa {car1.GetName()} ja {car3.GetName()} on sama määrä ovia.\n");
            }
            else
            {
                Console.WriteLine($"Autoissa {car1.GetName()} ja {car3.GetName()} on erimäärä ovia\n");
            }

            Truck truck1 = new Truck("Mercedez-Benz", "Atego", 2003, 7000, "6.4L", "Diesel", 4, 10000, 48);
            Console.Write("Kuorma-auto 1: ");
            truck1.PrintInformation();
            truck1.CalculateConsumption();
        }
    }
}
