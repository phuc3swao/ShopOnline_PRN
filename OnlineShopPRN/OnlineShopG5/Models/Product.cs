﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShopG5.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public double? Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
