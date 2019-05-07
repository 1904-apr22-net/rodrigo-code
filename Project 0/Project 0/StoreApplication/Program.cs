using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Extensions.Logging;
using StoreClasses;
using NLog;
using ILogger = NLog.ILogger;
using StoreDataAccess;
using StoreApplication;
using System.Linq;

namespace StoreApplication
{
    class Program
    {
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        // place orders to store locations for customers
        // get a suggested order for a customer based on his order history
        // search customers by name
        // display details of an order
        // display all order history of a store location
        // display all order history of a customer
        // display order history sorted by earliest, latest, cheapest, most expensive
        // display some statistics based on order history
        // search customers by name
        // persistent data(SQL)
        // input validation
        // exception handling
        // logging
        public static List<Customer> CustomerList = new List<Customer>();
        public static void Main(string[] args)
        {
            
            Console.WriteLine("What do you want to do?\n"
                +"1. Place Order for Customer\n"
                +"2. Get order suggestion for a customer\n"
                +"3. Search customer by name\n"
                +"4. Display details of an order\n"
                +"5. Display order history of a store location\n" //remember to sort
                +"6. Display order history of a customer\n" //remember to sort
                +"7. Display some statistics based on order history\n"
                +"Hit Enter to exit program\n"
                );

            int Input = Convert.ToInt32(Console.ReadLine());
            if(Input == 1)
            {
                StoreRepository storeRepository = Dependencies.CreateStoreRepository();
                // var DBcontext = Dependencies.CreateDBContext();
                var locations = storeRepository.GetLocation().ToList();
                for (var i = 1; i <= locations.Count; i++)
                {
                    Location location = locations[i - 1];
                    var locationString = $"{i}: \"{location.Name}\"";
                    Console.WriteLine(locationString + "\n");
                }



            }
            
        }
        
    }
}
