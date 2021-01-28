using System;

namespace B2_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //适配器模式，内部增加Helper实现类, 重写原来的接口方法


            //Abstraction（抽象类）,RefinedAbstratction（扩充抽象类）
            //Implementor（实现类接口）,ConcreteImplementor（具体实现类）

            AbsImage image = (AbsImage)AppConfigHelper.GetImageInstance();
            ImageImplementor imageImpl = (ImageImplementor)AppConfigHelper.GetEnvInstance();

            // 抽象类实现类调用接口实现类 (接口实现类作为抽象类实现类的属性之一)
            image.SetImageImplementor(imageImpl);
            image.ParseFile("小龙女");

            Console.ReadKey();
        }
    }
}
