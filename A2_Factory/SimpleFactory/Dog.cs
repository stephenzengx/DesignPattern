using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.SimpleFactory
{
    public class Dog : IEat
    {
        public void eat()
        {
            Console.WriteLine("dog eat");
        }
    }
}
