using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class ProductVersion
    {
        public int VersionNumber { get; set; }
        public string Naming { get; set; }

        public ProductVersion(int number, string name)
        {
            VersionNumber = number;
            Naming = name;
        }
    }
}
