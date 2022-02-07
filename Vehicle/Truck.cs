using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Truck : Car
    {
        protected double load;
        protected double consumption;

        public Truck(string make, string model, int modelYear, double price, double engine, string type, int doors, double load, double consumption) : base (make, model, modelYear, price, engine, type, doors)
        {
            this.load = load;
            this.consumption = consumption;
        }

        public double CalculateConsumption()
        {
           double fuelConsumption = load*consumption ;
           return fuelConsumption;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Kuorman paino: {this.load}, kulutus/kg: {this.consumption}");
        }
    }
}
