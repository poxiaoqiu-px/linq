using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Except_2
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var products = list.GetProductList();
            var customers = list.GetCustomerList();

            var productFirstChars =
                from p in products
                select p.ProductName[0];
            var customerFirstChars =
                from c in customers
                select c.CompanyName[0];
            Console.WriteLine();
            Console.WriteLine("Except_2 点标记");
            //Numbers < 5:
            var result = productFirstChars.Except(customerFirstChars).OrderBy(x => x);
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            Console.WriteLine();
            Console.WriteLine("Except_2 查询表达式");
            //Numbers < 5:
            //var result = (from t in numbersA
            //              select t).Union(from t in numbersB select t) ;
            //Print(result);
        }

        private void Print(IEnumerable<char> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }




}
