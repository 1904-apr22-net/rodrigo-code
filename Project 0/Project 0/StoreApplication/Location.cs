using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication
{
    public class Location
    {
        public Dictionary<Products, int> Inventory{get; set;}

        public List<Order> OrderHistory { get; set; }

    }
}
