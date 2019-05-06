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

        public List<Customer> AllCustomers { get; set; }
     

        public void Output()
        {
            Console.WriteLine("Customer Name: " + this.FirstName + " " + this.LastName+" At: "+this.CustLocation.Name+" Location");
        }
        public void custOrder()
        {
            Order just = new Order();
            just.Customer = this;
            just.Location = this.CustLocation;
           // just.OrderTime = GetTimestamp(DateTime.Now);

        }
    }
}
