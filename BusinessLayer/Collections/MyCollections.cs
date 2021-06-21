using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace BusinessLayer
{
    public class MyCollections
    {
        public ArrayList arrayL { get; set; }
        public List<Product> ListP { get; set; }
        public Dictionary<string, Product> DictionaryP { get; set; }
        public SortedList<string, Product> SortedL { get; set; }

        Product cushion;
        Product laptop;
        Developer coder;

        public MyCollections()
        {
            arrayL = new ArrayList();
            ListP = new List<Product>();
            DictionaryP = new Dictionary<string, Product>();
            SortedL = new SortedList<string, Product>();

            cushion = new Product("Sleepwell");
            coder = new FrontEndDeveloper("Coder");
            laptop = new Product("Dell Inspiron");
        }
        public void AddToArrayList()
        {
            arrayL.Add(cushion);    //any class object added to non-generic array list and dynamic method dispatch is happening at runtime.
            arrayL.Add(coder);
        }

        public void AddToGenericList()
        {
            ListP.Add(cushion);
            //ListP.Add(coder); Restricted
            ListP.Add(laptop);
        }

        public void AddToDictionary()
        {
            cushion.Cost = 1020;
            DictionaryP.Add(cushion.ProductName, cushion);
            laptop.Cost = 80000;
            DictionaryP.Add(laptop.ProductName, laptop);
        }

        public string GetFromArrayList()
        {
            String result = string.Empty;
            foreach(object obj in arrayL)
            {
                if (obj is Product) result += ((Product)cushion).ProductName + Environment.NewLine;
                else result += ((FrontEndDeveloper)obj).DeveloperName + Environment.NewLine;
            }
            return result;
        }

        public string GetFromGenericList()
        {
            String result = string.Empty;
            foreach(Product prod in ListP)
            {
                result += prod.ProductName + Environment.NewLine;
            }
            return result;
        }

        public string GetFromGenericDictionary()
        {
            String result = "Key-------------Cost" + Environment.NewLine;
            foreach(var prod in DictionaryP)
            {
                result += prod.Key + "\t" + prod.Value.Cost + Environment.NewLine;
            }
            return result;
        }

        public string GetKeysFromGenericDictionary()
        {
            String result = string.Empty;
            foreach (var key in DictionaryP.Keys) result += key + Environment.NewLine;
            return result;
        }

        public string GetValuesFromGenericDictionary()
        {
            String result = string.Empty;
            foreach (var value in DictionaryP.Values) result += value.Cost + Environment.NewLine;
            return result;
        }

        public bool SearchInGenericDictionary(string key)
        {
            //return (DictionaryP.Keys.ToList().Contains(key))?true:false;
            return DictionaryP.ContainsKey(key) ? true : false;
        }

        public void AddToGenericSortedList()
        {
            SortedL.Add(cushion.ProductName,cushion);
            SortedL.Add(laptop.ProductName,laptop);
        }

        public string GetAlphanumericSortedFromSortedList()
        {
            String result = "Key-------------Cost" + Environment.NewLine;
            foreach (var item in SortedL)
            {
                result += item.Key + "\t" + item.Value.Cost + Environment.NewLine;
            }
            return result;
        }
    }
}
