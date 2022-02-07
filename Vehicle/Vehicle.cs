using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
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
            Console.Write($"Auto: {this.make}, malli: {this.model}, vuosimalli: {this.modelYear}, hinta: {this.price}, ");
        }
    }
}
