using System;
//using A1_Singleton.basic;
//using A1_Singleton.ehan;
using A1_Singleton.nested;

namespace A1_Singleton
{
    public class Program
    {
        //饿汉单例,懒汉单例,静态内部类单例
        public static void Main(string[] args)
        {
            #region basic
            LoadBalancer balancer1, balancer2, balancer3;
            balancer1 = LoadBalancer.GetLoadBalancer();
            balancer2 = LoadBalancer.GetLoadBalancer();
            balancer3 = LoadBalancer.GetLoadBalancer();

            // 判断负载均衡器是否相同
            if (balancer1 == balancer2 && balancer1 == balancer3 && balancer2 == balancer3)
            {
                Console.WriteLine("^_^ : 服务器负载均衡器是唯一的！");
            }
            #endregion
        }
    }
}
