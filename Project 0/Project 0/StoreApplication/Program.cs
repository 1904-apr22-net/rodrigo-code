using System;
using System.Globalization;

namespace StoreApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer Rod = new Customer();
            Location L1 = new Location();
            string FName = "Rodrigo";
            string LName = "Salomon";
            L1.Name = "Dallas";
            Rod.CreateCustomer(FName, LName);
            Rod.CustLocation = L1;
            Rod.Output();

        }
    }
}
