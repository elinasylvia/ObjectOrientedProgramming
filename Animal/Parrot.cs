using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Parrot : Bird
    {

        protected string family; //laji

        public Parrot()
        {
        }

        public Parrot(string family, string name, int age, string birdClass, int legs) : base (name, age, birdClass, legs)
        {
            this.family = family;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
