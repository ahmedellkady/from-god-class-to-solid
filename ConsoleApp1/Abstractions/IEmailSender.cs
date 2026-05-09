using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Abstractions
{
    internal interface IEmailSender
    {
        void Send(string to, string subject, string body);
    }
}
