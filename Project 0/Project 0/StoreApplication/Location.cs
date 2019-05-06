using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication
{
    public class Location
    {
        //public Dictionary<Products, int> Inventory{get; set;}
        public Dictionary<Products, int> Inventory{get; set;} 

        public List<Order> OrderHistory { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

    }
}
