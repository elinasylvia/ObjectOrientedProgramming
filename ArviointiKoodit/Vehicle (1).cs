using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleExercise
{
    abstract class Vehicle
    {
        protected string make;
        protected string model;
        protected int modelYear;
        protected double price;

        public Vehicle()
        {
        }

        public Vehicle(string make, string model, int modelYear, double price)
        {
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine($"Merkki ja malli: {this.make}, {this.model}. Vuosimalli: {this.modelYear}, Hinta: {this.price}");
        }

        public string GetName()
        {
            return this.model;
        }
    }
}
