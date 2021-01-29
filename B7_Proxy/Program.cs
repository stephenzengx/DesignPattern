using System;

namespace B7_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //个人理解
            //代理模式通过一个代理类把属性类的都开放给代理供外部调用，提供了多个调用入口
            //而外观模式通过一个外观类把所有的实现过程都隐藏起来只提供了一个调用入口
            ISearcher searcher = new ProxySearcher();
            if (searcher != null)
            {
                string result = searcher.DoSearch("杨过", "玉女心经");
            }

            Console.ReadKey();
        }
    }
}
