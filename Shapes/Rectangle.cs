using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle :Shape
    {
        double length;
        double width;

        public Rectangle(double length, double width, string color) : base ("RECTANGLE", color)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return this.length * this.width;
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
