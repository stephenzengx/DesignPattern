using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.FactoryMethod
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    internal interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
