using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class Circle
    {
        /*
Circle Class
o Write a Circle class with a radius attribute.
o Use constructor chaining to initialize radius with both default and
user-provided values.
         */
        public double Radius;
        // Default Constructor
        public Circle() : this(1.0)
        {
        }
        // Parameterized Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
