using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
   abstract class Vehicle1
    {
        protected string brand;
        protected string model;
        protected int modelYear;
        protected double price;


        public Vehicle1(string brand, string model, int modelYear, double price)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine($"Brand: {this.brand} | Model: {this.model} | Model year: {this.modelYear} | Price: {this.price} EUR.");
        } 



    }
}
