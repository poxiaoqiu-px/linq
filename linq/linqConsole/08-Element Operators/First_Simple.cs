using System;
using System.Collections.Generic;
using System.Linq;

namespace linqConsole
{
    public class First_Simple
    {
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Product product12 = (
                from p in products
                where p.ProductID == 12
                select p)
                .First();
            Console.Write(product12.ProductID);
        }
    }
}
