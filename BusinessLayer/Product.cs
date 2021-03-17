using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Product
    {
        public string ProductName { get; set; }

        public Product(string name)
        {
            ProductName = name;
        }
        
        public string PrintProduct(Product product) {
            if (product is SoftwareProduct) return $"Software Product: {ProductName}";
            else if (product is HardwareProduct) return $"Hardware Product: {ProductName}";
            else return $"General Product: {ProductName}";
        }
    }
}
