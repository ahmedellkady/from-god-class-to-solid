using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Infrastructure.Storage
{
    internal class ArchiveOrderStorage
    {
        public IEnumerable<Order> GetAll()
        {
            return Enumerable.Empty<Order>();
        }
    }
}
