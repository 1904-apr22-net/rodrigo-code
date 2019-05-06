using System;
using System.Collections.Generic;

namespace StoreDataAccess.Entities
{
    public partial class Location
    {
        public Location()
        {
            Customers = new HashSet<Customers>();
            InventoryItem = new HashSet<InventoryItem>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<InventoryItem> InventoryItem { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
