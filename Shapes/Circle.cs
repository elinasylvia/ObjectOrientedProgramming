using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            this.radius = 0;
        }

        public Circle(string color, double radius) : base("CIRCLE", color)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
