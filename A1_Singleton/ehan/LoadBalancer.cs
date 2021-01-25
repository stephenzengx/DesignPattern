using System;
using System.Collections.Generic;
using System.Text;

namespace A1_Singleton.ehan
{
    public class LoadBalancer
    {
        //无法延迟加载
        public static readonly LoadBalancer loadBalancer = new LoadBalancer();
        
        public static LoadBalancer GetLoadBalancer()
        {
            return loadBalancer;
        }
    }
}
