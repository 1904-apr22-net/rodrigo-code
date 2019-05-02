using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace StoreApplication
{
    //has a store location
    //has a customer
    //has an order time(when the order was placed)
    //must have some additional business rules
    public class Order
    {
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public TimeSpan OrderTime { get; set; }
        public List<Products> ProductsOrdered { get; set; } 

    }
}
