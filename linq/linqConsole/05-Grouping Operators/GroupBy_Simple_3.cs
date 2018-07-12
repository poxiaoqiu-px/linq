using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class GroupBy_Simple_3
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Console.WriteLine();
            Console.WriteLine("GroupBy_Simple_3 点标记");
            //n % 5
            var result = products.GroupBy(g => g.Category).Select(g => new { Category = g.Key, products = g });
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
            Console.WriteLine("GroupBy_Simple_3 查询表达式");
            //n % 5
            var result = from w in products
                         group w by w.Category into g
                select new { Category = g.Key, Products = g };

            Print(result);
        }

        private void Print(IEnumerable<object> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }




}
