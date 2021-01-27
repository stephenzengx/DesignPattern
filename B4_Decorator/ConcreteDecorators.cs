using System;
using System.Collections.Generic;
using System.Text;

namespace B4_Decorator
{
    /// <summary>
    /// 滚动条装饰类：具体装饰类
    /// </summary>
    public class ScrollBarDecorator : Decorator
    {
        public ScrollBarDecorator(Component component) : base(component)
        {

        }

        public override void Display()
        {
            this.SetScrollBar();
            base.Display();
        }

        public void SetScrollBar()
        {
            Console.WriteLine("为构件增加滚动条!");
        }
    }

    /// <summary>
    /// 黑色边框装饰类：具体装饰类
    /// </summary>
    public class BlackBorderDecorator : Decorator
    {
        public BlackBorderDecorator(Component component) : base(component)
        {

        }

        public override void Display()
        {
            this.SetScrollBar();
            base.Display();
        }

        public void SetScrollBar()
        {
            Console.WriteLine("为构件增加黑色边框!");
        }
    }
}
