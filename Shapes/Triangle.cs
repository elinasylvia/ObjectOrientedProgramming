using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle : Shape
    {
        double length;
        double width;
        
        public Triangle(double length, double width, string color) : base ("TRIANGLE", color)
        {
            this.length = length;
            this.width = width;
           
        }

        public override double GetArea()
        {
            return this.length*this.width/2;
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
