using System;

namespace CarExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car tehtävä");
            Car car1 = new Car();
            car1.AskData();
            car1.ShowCarInfo();
            car1.Accelerate(10);
            car1.Brake();
            car1.ShowCarInfo();

            Car car2 = new Car();
            car2.AskData();
            car2.ShowCarInfo();
            car2.Accelerate(15);
            car2.Brake();
            car2.ShowCarInfo();
            Console.WriteLine("Car tehtävä loppui");
        }
    }
}
