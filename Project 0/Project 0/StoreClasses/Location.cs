using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses
{
    public class Location
    {
        public int Id { get; set; }
        //public Dictionary<Products, int> Inventory{get; set;}
        //public Dictionary<Products, int> Inventory{get; set;} 

        //public List<Order> OrderHistory { get; set; }

        public string Name { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }


    }
}
