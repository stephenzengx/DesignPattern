using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.FactoryMethod
{
    public class FileLogger : ILogger
    {
        public void WriteLog(string info)
        {
            Console.WriteLine("FileLogger:" + info);
        }
    }
}
