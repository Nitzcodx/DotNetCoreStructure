using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class InvalidCarTypeException : Exception
    {
       
        public InvalidCarTypeException(string message) : base(message)
        {

        }
    }
}
