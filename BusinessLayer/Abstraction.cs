using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Abstraction : MyAbstractClass
    {
        //public Abstraction():base()
        //{

        //}
        public override string AbstractMethod()
        {
            return $"Abstract Method Called :)";
        }
    }
}
