using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Application.Processing
{
    internal class OrderProcessor
    {
        private readonly IOrderValidator _validator;
        private readonly IDiscountCalculator _discountCalculator;
        private readonly IOrderWriter _orderWriter;
        private readonly IOrderNotifier _orderNotifier;
        private readonly IOrderLogger _logger;

        public OrderProcessor(IOrderValidator validator, IDiscountCalculator discountCalculator, IOrderWriter orderWriter, IOrderNotifier orderNotifier, IOrderLogger logger)
        {
            _validator = validator;
            _discountCalculator = discountCalculator;
            _orderWriter = orderWriter;
            _orderNotifier = orderNotifier;
            _logger = logger;
        }

        public void ProcessOrder(Order order)
        {
            _logger.Log($"Processing order {order.Id}");

            if (!_validator.isValid(order))
            {
                return;
            }

            var discount = _discountCalculator.CalculateDiscount(order);
            var finalAmount = order.TotalAmount - (order.TotalAmount * discount);

            _orderWriter.Save(order);
            _orderNotifier.SendConfirmationEmail(order);
        }
    }
}
