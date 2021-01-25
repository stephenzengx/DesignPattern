using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.SimpleFactory
{
    //简单工厂(静态工厂方法)
    public class AnimalSimpleFactory 
    {         
        public static IEat GetAnimal(string animalType)
        {
            IEat animal = null;

            if (animalType == "Pig")
                return new Pig();
            else if (animalType == "Dog")
                return new Dog();

            return animal;
        }
    }
}
