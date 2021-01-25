using System;
using System.Collections.Generic;
using System.Text;

namespace A1_Singleton.lanhan
{
    public class LoadBalancer
    {
        public static LoadBalancer loadBalancer = null;

        public static readonly object syncLocker = new object();

        //延迟加载(lazy load),  双重检查锁定(double-check locking)
        //安全控制繁琐，而且性能受影响
        public static LoadBalancer GetLoadBalancer()
        {
            if (loadBalancer != null)//解决了 进入函数每次都要加锁的问题
            {
                lock (syncLocker)
                {
                    if (syncLocker == null)//解决创建多个实例的问题
                    {
                        loadBalancer = new LoadBalancer();
                    }
                }
            }

            return loadBalancer;
        }
    }
}
