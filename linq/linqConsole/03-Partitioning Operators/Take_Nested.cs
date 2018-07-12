using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Take_Nested
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var customers = list.GetCustomerList();
            Console.WriteLine();
            Console.WriteLine("Take_Nested 点标记");
            //First 3 numbers:
            //var result = customers.Where(c=>c.Region=="WA").J
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
            Console.WriteLine("Take_Nested 查询表达式");
            //First 3 numbers:
            var result = (from a in customers
                          from b in a.Orders
                          where a.Region == "WA"
                          select new { a.CustomerID, b.OrderID, b.OrderDate }).Take(3);
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
