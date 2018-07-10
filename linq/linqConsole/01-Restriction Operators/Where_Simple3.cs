using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Where_Simple3
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var productList = new ProductList();
            var soldOutProducts = productList.GetProductList();
            Console.WriteLine();
            Console.WriteLine("Where_Simple3 点标记");
            //In-stock products that cost more than 3.00
            var result = soldOutProducts.Where(t => t.UnitsInStock>0 && t.UnitPrice>3.0M);
            foreach (var item in result)
            {
                Console.WriteLine($"{ item.ProductName} is in stock and costs more than 3.00.!");
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
            Console.WriteLine("Where_Simple3 查询表达式");
            //In-stock products that cost more than 3.00
            var result = from t in soldOutProducts
                       where t.UnitsInStock >0
                              && t.UnitPrice>3.0M
                       select t;
            foreach (var item in result)
            {
                Console.WriteLine($"{ item.ProductName} is in stock and costs more than 3.00.!");
            }
        }
    }

    

    
}
