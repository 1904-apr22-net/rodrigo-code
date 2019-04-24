using System;
using Shapes.UI;

namespace Shapes.Library
{
    public class Circle
    {
        // field (most fundemantal to put data in a class)
        private double radius;
        // methods
        // getters

        public double GetRadius()
        {
            return radius;
        }

        //setters
        public double SetRadius(double radius)
        {
            if(radius <0)
            {
               Console.WriteLine("Not allowed!");
            }
            this.radius = radius;
        }

    }
}
