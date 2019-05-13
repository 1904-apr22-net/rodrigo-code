using System;
using System.Collections.Generic;

namespace StoreApplication.DataAccess.Entities
{
    public partial class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Id { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
