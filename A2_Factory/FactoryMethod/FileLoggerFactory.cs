using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.FactoryMethod
{
    //工厂模式结合单例模式 ==>等价于 在.net core 将FileLogger声明成 singleton)
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return Nested.fileLogger;
        }

        class Nested {
            static Nested() {
                //这里可能会有一些初始化操作
                fileLogger = new FileLogger();
            }

            internal static FileLogger fileLogger = null;      
        }
    }
}
