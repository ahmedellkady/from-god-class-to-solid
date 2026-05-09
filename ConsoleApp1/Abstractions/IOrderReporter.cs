using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Abstractions
{
    internal interface IOrderReporter
    {
        string GenerateReport(IEnumerable<Order> orders);
    }
}
