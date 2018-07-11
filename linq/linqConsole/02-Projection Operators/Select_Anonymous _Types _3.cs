using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Select_Anonymous_Types_3
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            Console.WriteLine();
            Console.WriteLine("Select_Anonymous_Types_3 点标记");
            //Product Info:p.ProductName, p.Category, Price = p.UnitPrice
            var result = products.Select(t => new { t.ProductName,t.Category,Price=t.UnitPrice});
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
            Console.WriteLine("Select_Anonymous_Types_3 查询表达式");
            //Product Info:
            var result = from t in products
                select new { t.ProductName, t.Category, Price = t.UnitPrice };
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
