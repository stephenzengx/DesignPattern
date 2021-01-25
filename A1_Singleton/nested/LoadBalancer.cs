using System;
using System.Collections.Generic;
using System.Text;

namespace A1_Singleton.nested
{
    public class LoadBalancer
    {
        //静态内部类
        public static LoadBalancer GetLoadBalancer()
        {
            //当第一次用到这个嵌套类型的时候，会调用静态构造函数创建LoadBalancer的实例instance
            //如果我们不调用属性LoadBalancer.GetLoadBalancer()，那么就不会触发.NET运行时（CLR）调用Nested，也就不会创建实例，
            return Nested.loadBalancer;
        }

        class Nested {
            static Nested() { }
            
            internal static LoadBalancer loadBalancer = new LoadBalancer();
        }
    }
}
