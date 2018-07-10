using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Where_Simple2
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var productList = new ProductList();
            var soldOutProducts = productList.GetProductList();
            Console.WriteLine();
            //找出products中UnitsInStock == 0
            Console.WriteLine("Where_Simple2 点标记");
            //找出products中UnitsInStock == 0
            var result = soldOutProducts.Where(t => t.UnitsInStock == 0);
            foreach (var item in result)
            {
                Console.WriteLine($"{ item.ProductName} is sold out!");
            }
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            var productList = new ProductList();
            var soldOutProducts = productList.GetProductList();
            Console.WriteLine();
            Console.WriteLine("Where_Simple2 查询表达式");
            //找出products中UnitsInStock == 0
            var result = from t in soldOutProducts
                       where t.UnitsInStock == 0
                       select t;
            foreach (var item in result)
            {
                Console.WriteLine($"{ item.ProductName} is sold out!");
            }
        }
    }

    

    
}
