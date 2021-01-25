using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.SimpleFactory
{
    public class Pig : IEat
    {
        public void eat()
        {
            Console.WriteLine("pig eat");
        }
    }
}
