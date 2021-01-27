using System;

namespace B4_Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Component component = new Window();
            // 一次装饰
            Component componentSB = new ScrollBarDecorator(component);
            componentSB.Display();

            Console.WriteLine();
            // 二次装饰
            Component componentBB = new BlackBorderDecorator(componentSB);
            componentBB.Display();

            Console.ReadKey();
        }
    }
}
