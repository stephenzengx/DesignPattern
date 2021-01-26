using A2_Factory.AbstractFactory;
using A2_Factory.FactoryMethod;
using A2_Factory.SimpleFactory;
using System;

namespace A2_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1- 简单工厂:
            3个角色：Factory-工厂角色, Product-抽象产品角色, ConcreteProduct-具体产品角色
             */
            //IEat animal = AnimalSimpleFactory.GetAnimal(AppConfigHelper.GetSimpleAnimalType());
            //animal.eat();

            //2- 工厂方法
            //有时候，为了进一步简化客户端的使用，还可以对客户端隐藏工厂方法，此时，在工厂类中将直接调用产品类的业务方法，
            //客户端无须调用工厂方法创建产品，直接通过工厂即可使用所创建的对象中的业务方法。
            //ILoggerFactory loggerFactory = (ILoggerFactory)AppConfigHelper.GetLoggerFactoryInstance();
            //ILogger logger = loggerFactory.CreateLogger();
            //logger.WriteLog("test");

            //3- 抽象工厂方法
            ISkinFactory skinFactory = (ISkinFactory)AppConfigHelper.GetSkinFactoryInstance();
            skinFactory.CreateButton().Display();
            skinFactory.CreateTextField().Display();
            skinFactory.CreateComboBox().Display();
        }
    }
}
