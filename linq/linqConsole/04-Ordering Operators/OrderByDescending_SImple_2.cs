using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class OrderByDescending_SImple_2
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Console.WriteLine();
            Console.WriteLine("OrderByDescending_SImple_2 点标记");
            //First numbers less than 6:
            var result = products.OrderByDescending(x=>x.UnitsInStock);
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
            Console.WriteLine("OrderByDescending_SImple_2 查询表达式");
            //First 3 numbers:
            var result = from c in products
                         orderby c.UnitsInStock descending
                         select c;
                           
            Print(result);
        }

        private void Print(IEnumerable<object> result)
        {
            foreach (Product item in result)
            {
                Console.WriteLine(item.UnitsInStock);
            }
        }
    }




}
