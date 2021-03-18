using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class EncapsulationClass
    {
        //properties
        public int PrimaryKey { get; set; }
        public string AnotherProperty { get; set; }

        //indexer
        public object this[int index]
        {
            get {
                if (index == 1)
                    return PrimaryKey;
                else
                    return AnotherProperty;

            }
            set {
                if (index == 2)
                    AnotherProperty = value.ToString();   //Unboxing
            }
        }

        //static variable
        private static int counter;

        //static constructor
        static EncapsulationClass()
        {
            counter = 1000;
        }


        public EncapsulationClass()
        {
            PrimaryKey = ++counter;
        }

        //static method
        public static int CountObjects()
        {
            return counter - 1000;
        }

    }
}
