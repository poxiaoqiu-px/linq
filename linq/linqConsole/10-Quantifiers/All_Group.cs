using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class All_Group
    {
        public void Show()
        {
            var list = new ProductList();
            //var products = list.GetProductList();
            //      var productGroups =
            //from p in products
            //group p by p.Category into g
            ////where (g == 0)
            //select new { Category = g.Key, Products = g.Group };
            //foreach (var item in productGroups.Products)
            //{
            //    Console.WriteLine(item);
            //}
            //var pro = products.GroupBy(x => x.Category).Any(p => p.UnitsInStock == 0);
            //string[] words = { "believe", "relief", "receipt", "field" };
            //bool iAfterE = words.Any(x => x.Contains("ei"));
            //Console.WriteLine($"There is a word that contains in the list that contains 'ei': {iAfterE}");
        }
    }
}
