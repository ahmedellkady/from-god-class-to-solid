using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Application.Discounts
{
    internal class PremiumDiscountStrategy : IDiscountStrategy
    {
        public string OrderType => "Premium";

        public decimal GetDiscount(Order order)
        {
            return 0.10m;
        }
    }
}
