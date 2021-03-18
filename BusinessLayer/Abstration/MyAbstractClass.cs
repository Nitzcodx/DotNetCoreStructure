using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public abstract class MyAbstractClass
    {
        public int AbstractClassProperty { get; set; }

        public MyAbstractClass()
        {
            AbstractClassProperty = 23;
        }

        public void NonAbstratMethod()
        {
            Console.WriteLine($"Non abstract method inside abstract class called");
        }

        public abstract string AbstractMethod();
    }
}
