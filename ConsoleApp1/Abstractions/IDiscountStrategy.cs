using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Abstractions
{
    internal interface IDiscountStrategy
    {
        string OrderType { get; }
        decimal GetDiscount(Order order);
    }
}
