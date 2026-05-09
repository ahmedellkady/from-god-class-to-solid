using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Application.Discounts
{
    internal class BulkDiscountStrategy : IDiscountStrategy
    {
        public string OrderType => "Bulk";

        public decimal GetDiscount(Order order)
        {
            return 0.20m;
        }
    }
}
