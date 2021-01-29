using System;
using System.Collections.Generic;
using System.Text;

namespace B7_Proxy
{
    class RealSearcher : ISearcher
    {
        /// <summary>
        /// 模拟查询商务信息
        /// </summary>
        /// <returns></returns>
        public string DoSearch(string userID, string keyword)
        {
            Console.WriteLine("{0} 使用关键词 {1}", userID, keyword);
            return "返回具体内容";
        }
    }
}
