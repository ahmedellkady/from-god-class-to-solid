using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Application.Discounts
{
    internal class DiscountCalculator : IDiscountCalculator
    {
        private readonly IEnumerable<IDiscountStrategy> _strategies;

        public DiscountCalculator(IEnumerable<IDiscountStrategy> strategies)
        {
            _strategies = strategies;
        }

        public decimal CalculateDiscount(Order order)
        {
            var strategy = _strategies.FirstOrDefault(strategy => string.Equals(strategy.OrderType, order.OrderType, StringComparison.OrdinalIgnoreCase));

            if (strategy == null)
            {
                return 0.00m;
            }

            return strategy.GetDiscount(order);
        }
    }
}
