using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car1 : Vehicle1
    {
        protected string engine;
        protected string type;
        protected int doors;
        

        public Car1(string brand, string model, int modelYear, double price, string engine, string type, int doors) : base (brand,model,modelYear,price)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
            
        }

        public override bool Equals(object obj)
        {
            return obj is Car1 car &&
                   brand == car.brand &&
                   model == car.model &&
                   modelYear == car.modelYear &&
                   price == car.price &&
                   engine == car.engine &&
                   type == car.type &&
                   doors == car.doors;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return  $"Brand: {base.brand} | Model: {base.model} | Model year: {base.modelYear} | Price: {base.price} | Engine: {this.engine} | Type: {this.type} | Doors: {this.doors}";
        }
    }
}
