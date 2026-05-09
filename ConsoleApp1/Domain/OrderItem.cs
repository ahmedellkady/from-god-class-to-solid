using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Domain
{
    internal class OrderItem
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
