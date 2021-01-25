using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.FactoryMethod
{
    //工厂模式结合单例模式 ==>等价于 在.net core 将FileLogger声明成 singleton)
    public class DataBaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return Nested.databaseLogger;
        }

        class Nested {
            static Nested() {
                //这里可能会有一些初始化操作
                databaseLogger = new DataBaseLogger();
            }

            internal static DataBaseLogger databaseLogger = null;      
        }
    }
}
