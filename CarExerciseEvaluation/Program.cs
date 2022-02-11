using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto Kilta uutuus autot:");
            /*Vehicle1 vehicle1 = new Vehicle1("Volvo", "XC70", 2021, 40000);*/

            Car1 carA1 = new Car1("Volvo", "XC70", 2021, 40000, "2.5L V6", "Wagon", 4);
            Console.WriteLine(carA1.ToString());

            Car1 carA2 = new Car1("Volvo", "XC70", 2021, 40000, "2.0L", "Wagon", 4);
            Console.WriteLine(carA2.ToString());

            Car1 carA3 = new Car1("Volvo", "XC70", 2021, 40000, "1.8L", "Wagon", 4);
            Console.WriteLine(carA3.ToString());

            Console.WriteLine("________________________________________________________________________________________________________________________");

            /*Vehicle1 vehicle2 = new Vehicle1("Volvo", "S60", 2021, 45000);*/

            Car1 carB1 = new Car1("Volvo", "S60", 2021, 45000, "3.0L V8", "Sedan", 4);
            Console.WriteLine(carB1.ToString());

            Car1 carB2 = new Car1("Volvo", "S60", 2021, 45000, "2.5L V6", "Sedan", 4);
            Console.WriteLine(carB2.ToString());

            Car1 carB3 = new Car1("Volvo", "S60", 2021, 45000, "2.0L", "Sedan", 4);
            Console.WriteLine(carB3.ToString());

            Console.WriteLine("________________________________________________________________________________________________________________________");

            if (carA1.Equals(carB1) == true)
            {
                Console.WriteLine($"Autot ovat saman merkkisiä ja mallisia");
            }
            else
            {
                Console.WriteLine($"Autot ovat eri merkkisiä.");
            }

            Truck truckA = new Truck("Scania", "R560", 2010, 50000, "16L", "Truck", 2, 12000, 2000);
            truckA.PrintInformation();
            Truck truckB = new Truck("Volvo", "FM7", 2011, 54000, "20L", "Truck", 2, 11000, 2200);
            truckB.PrintInformation();
            Truck truckC = new Truck("Scania", "R660", 2015, 60000, "16L", "Truck", 2, 13000, 2100);
            truckC.PrintInformation();

            Car1 carC = truckA as Car1;
           
            //Tyyppimuunnos truck --> Car
             //carC. 
        }



    }
}
