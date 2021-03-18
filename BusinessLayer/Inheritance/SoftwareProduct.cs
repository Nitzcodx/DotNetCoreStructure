using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class SoftwareProduct:Product
    {
        public DateTime LicenseExpiryDate { get; set; }
        public SoftwareProduct(string softwareName):base(softwareName)  //constructor chaining 2
        {
            LicenseExpiryDate = DateTime.Now.AddYears(1);
        }
    }
}
