using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Infrastructure.Storage
{
    internal class SqlOrderStorage : IOrderWriter, IOrderReader
    {
        public IEnumerable<Order> GetAll()
        {
            return Enumerable.Empty<Order>();
        }

        public void Save(Order order)
        {
            Console.WriteLine($"[SQL] Saved {order.Id}");
        }
    }
}
