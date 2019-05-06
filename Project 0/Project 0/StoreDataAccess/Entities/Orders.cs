using System;
using System.Collections.Generic;

namespace StoreDataAccess.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int CustomerId { get; set; }
        public int LocationId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
