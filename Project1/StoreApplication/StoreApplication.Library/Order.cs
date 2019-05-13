using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Library
{
    public class Order
    {
        public int Id { get; set; } = 0;
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public DateTime OrderTime { get; set; }
        
        public List<String> ProductsOrdered { get; set; } = new List<String>();

        public int Price { get; set; }
    }

    

}
