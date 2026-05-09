using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Application.Validation
{
    internal class OrderValidator : IOrderValidator
    {
        private readonly IOrderLogger _logger;

        public OrderValidator(IOrderLogger logger)
        {
            _logger = logger;
        }

        public bool isValid(Order order)
        {
            if (order.Items.Count == 0)
            {
                _logger.Log("No items.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(order.CustomerEmail))
            {
                return false;
            }

            return true;
        }
    }
}
