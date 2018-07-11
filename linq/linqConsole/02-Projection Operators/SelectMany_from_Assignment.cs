using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class SelectMany_from_Assignment
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {

            Console.WriteLine();
            Console.WriteLine("SelectMany_from_Assignment 点标记");
            //Pairs where a < b:
            //var result = ;
            //Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            var list = new ProductList();
            var customers = list.GetCustomerList();
            Console.WriteLine();
            Console.WriteLine("SelectMany_from_Assignment 查询表达式");
            //total >= 2000.0M
            var result = from c in customers
                         from o in c.Orders
                         where o.Total >= 2000.0M
                         select new { c.CustomerID, o.OrderID, total = o.Total };
            Print(result);
        }

        private void Print(IEnumerable<object> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }




}
