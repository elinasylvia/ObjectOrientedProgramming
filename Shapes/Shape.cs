using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        protected string type;
        protected string color;

        public Shape()
        {
            this.type = string.Empty;
            this.color = string.Empty;
        }

        public Shape(string type, string color)
        {
            this.type = type;
            this.color = color;
        }
        abstract public double GetArea();

        public virtual string GetColor()
        {
            return this.color;
        }
    }
}
