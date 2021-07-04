using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessLayer
{
    public class LetsQuery
    {
        public List<Product> products { get; set; }
        public LetsQuery()
        {
            products = new List<Product>
            {
                new HardwareProduct("RAM"),
                new HardwareProduct("ROM"),
                new HardwareProduct("Procesor"),
                new HardwareProduct("Graphics")
            };
        }
        public void GetProducts(out string deferredResult, out string immediateResult)
        {
            string deferredExecResult = string.Empty;

            string immediateExecResult = string.Empty;

            var query = from prod in products
                        select prod.ProductName;
            //var _methodquery = products.Select(n => n.ProductName);

            var immediateExec = (from prod in products
                        select prod.ProductName).ToList();

            products.Add(
                new SoftwareProduct("Photoshop")
            );

            foreach (var prod in query) deferredExecResult += prod + Environment.NewLine ;
            foreach (var prod in immediateExec) immediateExecResult += prod + Environment.NewLine;

            deferredResult = deferredExecResult;
            immediateResult = immediateExecResult;
            
        }

        public string GetRefinedProducts()
        {
            products.Add(
                new SoftwareProduct("Photoshop")
            );
            products.Add(
                new SoftwareProduct("Acrobar Reader")
            );

            products[0].Cost = 2389;
            products[1].Cost = 4678;
            products[2].Cost = 23579;
            products[3].Cost = 289;

            var query = (from product in products
                         where product is HardwareProduct
                         orderby product.Cost descending
                         select new { product.ProductName, product.Cost }).ToList();
            //new { product.ProductName, product.Cost } - Anonymous Type

            //var methodQuery = products.Where(p => p is HardwareProduct)
            //                    .Select(x => new { x.ProductName, x.Cost })
            //                        .OrderByDescending(y => y.Cost);

            string result = "Name \t Cost" + Environment.NewLine;
            foreach (var item in query) result += $"{item.ProductName}       {item.Cost + Environment.NewLine}";
            return result;

        }

        public string GroupByProducts()
        {
            string result = "Cost \t Count" + Environment.NewLine; ;

            products[0].Cost = 4500;
            products[1].Cost = 4500;
            products[2].Cost = 3400;
            products[3].Cost = 2000;

            var query = from product in products
                        group product by product.Cost into g
                        select new { g.Key, Count = g.Count() };

            //var methodQuery = products.GroupBy(p => p.Cost)
            //                    .Select(x => new { x.Key, Count = x.Count() });

            foreach (var item in query) result += $"{item.Key}     {item.Count + Environment.NewLine}";

            return result;
        }

        public string JoinProducts()
        {
            string result = "Cost \t Count" + Environment.NewLine; ;

            List<ProductVersion> versions = new List<ProductVersion>
            {
                new ProductVersion(1,"New Gen"),
                new ProductVersion(2,"Tiger Gen"),
                new ProductVersion(3,"Rocket Gen")
            };

            products[0].Version = 1;
            products[1].Version = 1;
            products[2].Version = 2;
            products[3].Version = 3;

            var _query = (from product in products
                          join version in versions
                          on product.Version equals version.VersionNumber
                          group product by version.Naming
                          into g
                          select new { g.Key, Count = g.Count() });

            //var methodQuery = products.Join(versions, p => p.Version, v => v.VersionNumber, (x, y) => new{x, y})
            //                    .GroupBy(version=>version.y.Naming)
            //                        .Select( x=> new {x.Key,Count = x.Count() });
                

            foreach(var item in _query) result += $"{item.Key}     {item.Count + Environment.NewLine}";

            return result;
        }
    }
}
