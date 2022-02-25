using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape : IComparable
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

        public virtual string GetInfo()
        {
            return $"Muoto: {this.type}, väri: {this.color}, pinta-ala {GetArea():F2}";
        }

        public string GetColor()
        {
            return this.color;
        }

        public int CompareTo(object obj)
        {
            Shape other = (Shape)obj;
            if (this.GetArea()< other.GetArea())
            {
                return 1;
            }
            if (other.GetArea() < this.GetArea())
            {
                return -1;
            }
            return 0;
        }
    }
}
