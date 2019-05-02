using System;
using System.Globalization;

namespace StoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = new TimeSpan(6, 30, 0);
            Console.WriteLine(time.ToString());
            
        }
    }
}
