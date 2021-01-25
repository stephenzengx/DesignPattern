using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.FactoryMethod
{
    /// <summary>
    /// 抽象产品类
    /// </summary>
    public interface ILogger
    {
        void WriteLog(string info);
    }
}
