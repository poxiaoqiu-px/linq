using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linqConsole
{
    public class FirstOrDefault_Condition
    {
        public void   Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Product product789 = products.FirstOrDefault(p => p.ProductID == 789);
            Console.WriteLine("Product 789 exists: {0}", product789 != null);
        }
    }
}
