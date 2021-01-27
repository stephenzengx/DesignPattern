using System;
using System.Collections.Generic;
using System.Text;

namespace B4_Decorator
{
    /// <summary>
    /// 窗体类：具体构件类 (继承抽象构件类)
    /// </summary>
    public class Window : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示窗体!");
        }
    }

    /// <summary>
    /// 文本框类：具体构件类
    /// </summary>
    public class TextBox : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示文本框!");
        }
    }

    /// <summary>
    /// 列表框类：具体构件类
    /// </summary>
    public class ListBox : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示列表框!");
        }
    }
}
