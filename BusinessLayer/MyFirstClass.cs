using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class MyFirstClass
    {
        public int MyFirstProperty { get; set; }

        public MyFirstClass()
        {
            MyFirstProperty = 23;
        }

        public int MyFirstMethod(int n)
        {
            return 2 * n;
        }
    }
}
