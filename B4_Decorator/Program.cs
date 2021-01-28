using System;

namespace B4_Decorator
{
    public class Program
    {
        //装饰者模式，在重写的方法里面 添加新的东西 (被装饰的对象作为基类被继承)
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
