using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Library
{
    public class Location
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public List<Customer> CustomersAtLocation { get; set; } = new List<Customer>();

        public List<Order> OrdersAtLocation { get; set; } = new List<Order>();
    }
}
