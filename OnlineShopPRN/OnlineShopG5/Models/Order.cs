using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShopG5.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public double Total { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
