using System;
using System.Collections.Generic;
using System.Text;

namespace C4_TemplateMethod
{
    /// <summary>
    /// 具体子类：CurrentAccount => 活期账户类
    /// </summary>
    public class CurrentAccount : Account
    {
        // 重写父类的抽象基本方法
        public override void CalculateInterest()
        {
            Console.WriteLine("按活期利率计算利息！");
        }

        // 重写父类的钩子方法
        public override bool IsAllowDisplay()
        {
            return base.IsAllowDisplay();
        }
    }

    /// <summary>
    /// 具体子类：SavingAccount => 定期账户类
    /// </summary>
    public class SavingAccount : Account
    {
        // 重写父类的抽象基本方法
        public override void CalculateInterest()
        {
            Console.WriteLine("按定期利率计算利息！");
        }

        // 重写父类的钩子方法
        public override bool IsAllowDisplay()
        {
            return false;
        }
    }
}
