using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{              
    class Car : Vehicle
    {
        protected double engine;
        protected string type;
        protected int doors;

        public Car()
        {
        }

        public Car(string make, string model, int modelYear, double price, double engine, string type, int doors) : base (make, model, modelYear, price)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public override bool Equals(object obj)
        {
            return obj is Car && (this.GetHashCode() == ((Car)obj).GetHashCode());
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"tyyppi: {this.type}, moottorin koko: {this.engine:F1}L, ovien lukumäärä: {this.doors}");
            
        }

        public override string ToString()
        {
            return $"{this.make} ({this.type}, {this.engine:F1}L, {this.doors} ovinen.)";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(engine, type, doors);
        }
    }
}
