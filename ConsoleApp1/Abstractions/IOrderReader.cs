using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Abstractions
{
    internal interface IOrderReader
    {
        IEnumerable<Order> GetAll();
    }
}
