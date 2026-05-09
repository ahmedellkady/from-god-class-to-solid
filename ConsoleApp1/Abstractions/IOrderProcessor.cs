using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Abstractions
{
    internal interface IOrderProcessor
    {
        void ProcessOrder(Order order);
    }
}
