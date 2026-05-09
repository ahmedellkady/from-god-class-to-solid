using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Application.Notifications
{
    internal class OrderEmailSender : IOrderNotifier
    {
        private readonly IEmailSender _emailSender;

        public OrderEmailSender(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void SendConfirmationEmail(Order order)
        {
            _emailSender.Send(order.CustomerEmail, $"Order {order.Id}", "...");
        }
    }
}
