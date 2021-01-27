using System;
using System.Collections.Generic;
using System.Text;

namespace B4_Decorator
{
    /// <summary>
    /// 抽象装饰类(继承并重写方法)
    /// </summary>
    public class Decorator : Component
    {
        private Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Display()
        {
            component.Display();
        }
    }
}
