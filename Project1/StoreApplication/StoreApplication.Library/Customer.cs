using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Library
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public Location CustLocation { get; set; }

        public List<Order> OrdersforCustomer { get; set; } = new List<Order>();
    }
}
