using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    /// <summary>
    /// one to many relationship
    /// </summary>
    public class Cart_HasA_Product_Aggregation_
    {
        public Product[] Products { get; set; }

        public Cart_HasA_Product_Aggregation_()
        {
            Products = null;
        }
        public Cart_HasA_Product_Aggregation_(Product[] products):this()    //constructor chaining 
        {
            Products = products;
        }

        public void PrintProducts()
        {
            foreach (Product product in Products) { Console.WriteLine(product.ProductName); }
        }
    }
}
