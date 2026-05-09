using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Abstractions
{
    internal interface IOrderLogger
    {
        void Log(string message);
    }
}
