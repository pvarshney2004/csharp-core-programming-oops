using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Class_and_Object.Level_01
{
    internal class Circle
    {
        public double Radius;
        // constructor to initialize circle radius
        public Circle(double radius)
        {
            Radius = radius;
        }
        // methods to calculate area and circumference of the circle
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
