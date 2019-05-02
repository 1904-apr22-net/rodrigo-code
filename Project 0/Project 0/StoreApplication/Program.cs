using System;
using System.Globalization;

namespace StoreApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan time = new TimeSpan(6, 30, 0);
            Console.WriteLine(time.ToString());
            
        }
    }
}
