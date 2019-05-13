using System;
using System.Collections.Generic;

namespace StoreApplication.DataAccess.Entities
{
    public partial class Product
    {
        public Product()
        {
            InventoryItem = new HashSet<InventoryItem>();
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual ICollection<InventoryItem> InventoryItem { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
