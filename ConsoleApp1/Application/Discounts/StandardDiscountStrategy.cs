using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Application.Discounts
{
    internal class StandardDiscountStrategy : IDiscountStrategy
    {
        public string OrderType => "Standard";

        public decimal GetDiscount(Order order)
        {
            return 0.00m;
        }
    }
}
