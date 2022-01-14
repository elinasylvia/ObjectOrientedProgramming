using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise1
{
    class Car
    {
        public string brand;
        public string color;
        public double speed;
        public Car()
        {
            this.brand = string.Empty;
            this.color = string.Empty;
            this.speed = 0;

        }
        public void AskData()
        {
            Console.Write("Anna auton merkki: ");
            this.brand = Console.ReadLine();
            Console.Write("Anna auton väri: ");
            this.color=Console.ReadLine();
            Console.Write("Anna auton nopeus: ");
            this.speed = int.Parse(Console.ReadLine());


        }
        public void Accelerate(int change) 
        {
            this.speed += change;

        }
        public void Brake()
        {
            double speedBreak=this.speed*0.1;
            if (this.speed >= speedBreak)
            {
                this.speed -= this.speed * 0.1;
            }
            
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on {this.brand},  auton väri on {this.color} ja auton nopeus on {this.speed}");
            
        }
    }
}
