using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    class Customer : ICustomer
    {
        private string name;
        private double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

       

        public double GetBonus()
        {
            if (purchases <= 1000)
            {
                return purchases * 0.02;
            }
            else if (purchases <= 2000)
            {
                return purchases * 0.03;
            }
            else
            {
                return purchases * 0.05;
            }

        }

        public Customer GetCustomer(string name)
        {
            if (name.Equals(this.name))
            {

                return this;
            }
            return null;
        }

     

        public override string ToString()
        {
            return this.name.ToString();
        }
    }
}
