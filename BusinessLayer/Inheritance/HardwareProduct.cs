using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class HardwareProduct:Product
    {
        public DateTime EOL { get; set; }   
        public HardwareProduct(string hardwareName):base(hardwareName)  //constructor chaining 2
        {
            EOL = DateTime.Now.AddYears(5);
        }
    }
}
