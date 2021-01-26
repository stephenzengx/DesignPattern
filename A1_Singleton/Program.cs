using System;
//using A1_Singleton.basic;
//using A1_Singleton.ehan;
using A1_Singleton.nested;


/*
 1-单例模式：
饿汉式单例：不能实现延迟加载
懒汉式单例：安全控制频繁
静态内部类单例：　解决了饿汉和懒汉式的问题
优点：该实现方法在内部定义了一个私有类型Nested。当第一次用到这个嵌套类型的时候，
    会调用静态构造函数创建LoadBalancer的实例instance。
    如果我们不调用属性LoadBalancer.GetLoadBalancer()那么就不会触发.NET运行时（CLR）调用Nested，
    也就不会创建实例，因此也就保证了按需创建实例（或延迟初始化）。
缺点：与具体编程语言本身的特性相关，有一些面向对象的编程语言并不支持此种方式。
 */
namespace A1_Singleton
{
    public class Program
    {
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
