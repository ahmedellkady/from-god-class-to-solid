using OrderSystem.Abstractions;
using OrderSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Application.Reports
{
    internal class OrderReportService : IOrderReporter, IOrderExporter
    {
        public string ExportToCsv(IEnumerable<Order> orders)
        {
            return string.Join("\n", orders.Select(o => $"{o.Id},{o.CustomerEmail},{o.TotalAmount}"));
        }

        public string GenerateReport(IEnumerable<Order> orders)
        {
            var orderList = orders.ToList();

            return $"Orders: {orderList.Count} | Revenue: {orderList.Sum(o => o.TotalAmount):C}";
        }
    }
}
