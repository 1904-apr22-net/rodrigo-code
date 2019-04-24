using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            Calculator calc = new Calculator();
            calc.multipleof3(n);
            Console.WriteLine();
            calc.multipleof3reverse(n);

        }
       
    }
}
