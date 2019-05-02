using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication
{
    //has a store location
    //has a customer
    //has an order time(when the order was placed)
    //must have some additional business rules
    class Order
    {
        Customer customer = new Customer();
        Location location = new Location();
        TimeSpan OrderTime = new TimeSpan(6, 30, 0);
        
    }
}
