using A2_Factory.FactoryMethod;
using A2_Factory.SimpleFactory;
using System;

namespace A2_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple factory
            //IEat animal = AnimalSimpleFactory.GetAnimal(AppConfigHelper.GetSimpleAnimalType());
            //animal.eat();

            //factory method
            ILoggerFactory loggerFactory = (ILoggerFactory)AppConfigHelper.GetLoggerFactoryInstance();
            ILogger logger = loggerFactory.CreateLogger();
            logger.WriteLog("test");
        }
    }
}
