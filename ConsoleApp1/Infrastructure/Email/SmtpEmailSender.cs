using OrderSystem.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Infrastructure.Email
{
    internal class SmtpEmailSender : IEmailSender
    {
        public void Send(string to, string subject, string body)
        {
            Console.WriteLine($"[SMTP] {to}");
        }
    }
}
