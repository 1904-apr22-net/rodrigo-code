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
    }
}
