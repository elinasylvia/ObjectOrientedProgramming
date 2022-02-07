using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Bird : Animal
    {

        protected string birdClass; //luokka
        protected int legCount;
        public Bird()
        {
            Console.WriteLine("Bird-luokan muodostin");
            this.birdClass = "lintu";
            this.legCount = 2;
        }

        //kutsuu kantaluokan muodostinta parametrilla
        public Bird(string name, int age, string birdClass, int legs) : base(name, age)

        {
            Console.WriteLine("Bird-luokan muodostin: ");
            this.birdClass = birdClass;
            this.legCount = legs;
        }

        public override bool Equals(object obj)
        {
            return obj is Bird bird &&
                this.birdClass == bird.birdClass &&
                this.legCount == bird.legCount;
                
                
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Luokka: {this.birdClass}, Jalkoja: {this.legCount}");
        }
        public override void Speak()
        {
            Console.WriteLine($"kraak");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.birdClass}, {this.legCount}";
        }
    }
}
