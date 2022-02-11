using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleExercise
{
    class Car : Vehicle
    {
        protected string engineSize;
        protected string type;
        protected int doors;

        public Car()
        {
        }

        public Car(string make, string model, int modelYear, double price, string engineSize, string type, int doors) : base(make, model, modelYear, price)
        {
            this.engineSize = engineSize;
            this.type = type;
            this.doors = doors;
        }

        public override bool Equals(object obj)
        {
            return obj is Car car &&
                this.doors == car.doors;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Moottorin koko ja malli: {this.engineSize}, {this.type}. Ovien lukumäärä: {this.doors}\n");
        }

        public override string ToString()
        {
            return $"Merkki ja malli: {this.make}, {this.model}. Vuosimalli: {this.modelYear}, Hinta: {this.price}\n" +
                   $"Moottorin koko ja malli: {this.engineSize}, {this.type}. Ovien lukumäärä: {this.doors}\n";
        }
    }
}
