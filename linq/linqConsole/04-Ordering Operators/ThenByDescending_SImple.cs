using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class ThenByDescending_SImple
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Console.WriteLine();
            Console.WriteLine("ThenByDescending_SImple 点标记");
            //Sorted digits:
            var result = products.OrderBy(x=>x.Category).ThenByDescending(x=>x.UnitPrice);
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
            Console.WriteLine("ThenByDescending_SImple 查询表达式");
            //Sorted digits:
            var result = from c in products
                         orderby c.Category,c.UnitPrice descending
                         select c;
                           
            Print(result);
        }

        private void Print(IEnumerable<object> result)
        {
            foreach (Product item in result)
            {
                Console.WriteLine(item.ProductID+" "+item.ProductName+" "+item.UnitPrice);
            }
        }
    }




}
