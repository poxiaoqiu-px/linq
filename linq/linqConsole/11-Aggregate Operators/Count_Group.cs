using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Count_Group
    {
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            var categoryCounts =
               from p in products
               group p by p.Category into g
               select new { Category = g.Key, ProductCount = g.Count() };
            foreach (var item in categoryCounts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
