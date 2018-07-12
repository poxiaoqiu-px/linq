using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Distinct_2
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Console.WriteLine();
            Console.WriteLine("Distinct_2 点标记");
            //Numbers < 5:
            var result = products.Select(x=>x.Category).Distinct();
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
            Console.WriteLine("Distinct_2 查询表达式");
            //Numbers < 5:
            var result = (from t in products
                          select t.Category).Distinct();
            Print(result);
        }

        private void Print(IEnumerable<string> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }




}
