using System;
//using Shapes.Library;

namespace Shapes.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();

            double r = cir.radius;
            cir.SetRadius(-4);
            Console.WriteLine("Hello World!");
        }
    }
}
