using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public static class IntegerExtension   ///must be non-generic static class
    {
        public static int GetFactorsCount(this int number) //must be static with this keyword as param
        {
            int c = 0;
            for(int f = 1; f < number; ++f)
            {
                if (number % f == 0) ++c;
            }
            return c;
        }

        public static bool IsEven(this int number)
        {
            return (number % 2 == 0) ? true : false;
        }
    }
}
