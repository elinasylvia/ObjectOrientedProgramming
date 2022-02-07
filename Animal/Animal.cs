using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    abstract class Animal
    {
        protected string name;
        protected int age;
        public Animal()
            
        {
            Console.WriteLine("Animal-kantaluokan muodostin");
            
        }

        public Animal (string name, int age)
        {
            Console.WriteLine("Animal-kantaluokan muodostin");
            this.name = name;
            this.age = age;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Nimi: {this.name}, Ikä: {this.age}");
        }

        public override string ToString()
        {
            return $"{this.name}, {this.age}";
        }

        public string GetName()
        {
            return this.name;
        }

        abstract public void Speak();
    }
}

