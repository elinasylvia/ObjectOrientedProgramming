using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleExercise
{
    class Truck : Car
    {
        public double load;
        public double consumption;

        public Truck()
        {
        }

        public Truck(string make, string model, int modelYear, double price, string engineSize, string type, int doors,
                     double load, double consumption) : base (make, model, modelYear, price, engineSize, type, doors)
        {
            this.load = load;
            this.consumption = consumption;
        }

        public void CalculateConsumption()
        {
            double calculatedConsumption;
            calculatedConsumption = this.load / this.consumption;

            Console.WriteLine($"Kuorma-auton kulutus on {Convert.ToInt32(calculatedConsumption)}");
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Kuorma-auton paino on {this.load}kg ja kulutus/kg: {this.consumption}.");
        }
    }
}
