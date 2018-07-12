using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class OrderBy_SImple_3
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Console.WriteLine();
            Console.WriteLine("OrderBy_SImple_3 点标记");
            //p.ProductName
            var result = products.OrderBy(x=>x.ProductName).ToList();
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Console.WriteLine();
            Console.WriteLine("OrderBy_SImple_3 查询表达式");
            //First 3 numbers:
            var result = (from c in products
                         orderby c.ProductName
                          select c).ToList();
                           
            Print(result);
        }

        private void Print(IEnumerable<object> result)
        {
            foreach (Product item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }




}
