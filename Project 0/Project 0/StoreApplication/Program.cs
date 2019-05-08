using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Extensions.Logging;
using StoreClasses;
using NLog;
using StoreDataAccess;
using StoreApplication;
using System.Linq;

namespace StoreApplication
{


    class Program
    {
        public static int NextOrderId = 0;
        //private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

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
            StoreRepository storeRepository = Dependencies.CreateStoreRepository();
            Console.WriteLine("What do you want to do?\n"
                + "1. Place Order for Customer\n"
                + "2. Get order suggestion for a customer\n"
                + "3. Search customer by name\n"
                + "4. Display details of an order\n"
                + "5. Display order history of a store location\n" //remember to sort
                + "6. Display order history of a customer\n" //remember to sort
                + "7. Display some statistics based on order history\n"
                + "8. Quit Program"
                );

            //int Input = Convert.ToInt32(Console.ReadLine());
            string input1 = Console.ReadLine();
            int input = 0;
            //Int32.TryParse(input, out number);
            if (!Int32.TryParse(input1, out input))
            {
                Console.WriteLine("invalid input, try again");
                Main(null);
            }
            else
            {
                input = Int32.Parse(input1);
            }
            if (input == 3)
            {
                //StoreRepository storeRepository = Dependencies.CreateStoreRepository();
                // var DBcontext = Dependencies.CreateDBContext();
                //var locations = storeRepository.GetLocation().ToList();
                /*
                for (var i = 1; i <= locations.Count; i++)
                {
                    Location location = locations[i - 1];
                    var locationString = $"{i}: \"{location.Name}\"";
                    Console.WriteLine(locationString + "\n");
                }
                
                
                var customers = locations[1].CustomersAtLocation;
                Console.WriteLine("Customer count= " + customers.Count);
                for (var i = 1; i <= customers.Count; i++)
                {
                    Customer customer = customers[i - 1];
                    var locationString = $"{i}: \"{customer.FirstName}\"";
                    Console.WriteLine(locationString + "\n");
                }
                Main(null);
                */
                List<Customer> toOrderFor = new List<Customer>();
                Console.WriteLine("Search customer, type first name");
                string input2 = Console.ReadLine();
                var locations = storeRepository.GetLocation().ToList();
                //for (var i = 0; i < locations.Count; i++)
                //var locations = storeRepository.GetLocation().ToList();
                for (var i = 0; i < locations.Count; i++)
                {
                    var customers = locations[i].CustomersAtLocation;
                    for (var j = 0; j < customers.Count; j++)
                    {
                        Customer customer = customers[j];
                        //Console.WriteLine(customer.FirstName);
                        if (customer.FirstName == input2)
                        {
                            // Console.WriteLine(customer.FirstName);
                            toOrderFor.Add(customer);
                        }
                    }
                }
                if (toOrderFor.Count == 0)
                {
                    Console.WriteLine("No such customer");
                    Main(null);
                }
                //Console.WriteLine(toOrderFor.Count);
                for (var i = 0; i < toOrderFor.Count; i++)
                {
                    Customer customer = toOrderFor[i];
                    Console.WriteLine("Customer: " + customer.FirstName + " " + customer.LastName);
                }
                Main(null);
            }
            if (input == 1) //Place Order for Customer
                {
                    Customer toOrderFor2 = null;
                    Console.WriteLine("Write customer first name");
                    string input3 = Console.ReadLine();
                    var locations2 = storeRepository.GetLocation().ToList();
                    for (var i = 0; i < locations2.Count; i++)
                    {
                        var customers = locations2[i].CustomersAtLocation;
                        for (var j = 0; j < customers.Count; j++)
                        {
                            Customer customer = customers[j];
                            //Console.WriteLine(customer.FirstName);
                            if (customer.FirstName == input3)
                            {
                                Console.WriteLine(customer.FirstName);
                                toOrderFor2 = customer;
                                toOrderFor2.CustLocation = locations2[i];
                            }
                        }
                    }
                    if (toOrderFor2 == null)
                    {
                        Console.WriteLine("Invalid customer, back to main menu.");
                        Main(null);
                    }
                    else
                    {
                        Console.WriteLine("What do you want to order?\n"
                            + "1: Burger\n"
                            + "2. Fries\n"
                            + "3. Drink\n"
                            + "4. Combo\n");
                    }
                    int orderedProduct = Convert.ToInt32(Console.ReadLine());
                    int returned = storeRepository.AddOrder(toOrderFor2, orderedProduct, Program.NextOrderId);
                    Program.NextOrderId = Program.NextOrderId + returned;
                }
                if (input == 4)
                {
                    Console.WriteLine("Choose an orderId");
                    int HereOrderId = Int32.Parse(Console.ReadLine());
                    storeRepository.DisplayOrder(HereOrderId);





                }
                if (input == 5)// prints locations
                {
                    //StoreRepository storeRepository = Dependencies.CreateStoreRepository();
                    // var DBcontext = Dependencies.CreateDBContext();
                    var locations2 = storeRepository.GetLocation().ToList();

                    for (var i = 1; i <= locations.Count; i++)
                    {
                        Location location = locations2[i - 1];
                        var locationString = $"{i}: \"{location.Name}\"";
                        Console.WriteLine(locationString + "\n");
                    }
                    /*

                    var customers = locations[1].CustomersAtLocation;
                    Console.WriteLine("Customer count= " + customers.Count);
                    for (var i = 1; i <= customers.Count; i++)
                    {
                        Customer customer = customers[i - 1];
                        var locationString = $"{i}: \"{customer.FirstName}\"";
                        Console.WriteLine(locationString + "\n");
                    }
                    */
                    Main(null);
                }

            }
        }
    }


