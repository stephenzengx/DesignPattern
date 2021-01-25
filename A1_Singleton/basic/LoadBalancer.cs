using System;
using System.Collections.Generic;
using System.Text;

namespace A1_Singleton.basic
{
    public class LoadBalancer
    {
        private static LoadBalancer instance = null;

        public static LoadBalancer GetLoadBalancer()
        {           
            if (instance == null)
            {
                //初始化时间非常长的话 并发会存在问题会创建多个实例
                instance = new LoadBalancer();
            }

            return instance;
        }
    }
}
