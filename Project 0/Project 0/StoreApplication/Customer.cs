using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication

{
    //has first name, last name, etc.
    //has a default store location to order from
    //cannot place more than one order from the same location within two hours
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Location CustLocation { get; set; }

        public Order CustOrder { get; set; }

        public List<Order> custOrderHistory { get; set; }

        public void CreateCustomer()
        {
            Console.WriteLine("Create new Customer? (y/n)");
            string line = Console.ReadLine();
            if ( line == "n")
            {
                return;
            }
            else
            Customer 
            {
                Console.WriteLine("Type first name:");
                
            }


        }
        

        public void Output()
        {
            Console.WriteLine("Customer Name: " + this.FirstName + " " + this.LastName+" At: "+this.CustLocation.Name+" Location");
        }
    }
}
