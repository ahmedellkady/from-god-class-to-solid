using OrderSystem.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Infrastructure.Logging
{
    internal class ConsoleOrderLogger : IOrderLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
