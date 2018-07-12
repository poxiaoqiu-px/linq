using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class SelectMany_Indexed
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var customers = list.GetCustomerList();
            Console.WriteLine();
            Console.WriteLine("SelectMany_Indexed 点标记");
            //Pairs where a < b:
            var result = customers.SelectMany((cust, index) =>
                cust.Orders.Select(o => "Customer #" + (index + 1) +
                                   " has an order with OrderID " + o.OrderID)
            );
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            var list = new ProductList();
            var customers = list.GetCustomerList();
            DateTime cutoffDate = new DateTime(1997, 1, 1);
            Console.WriteLine();
            Console.WriteLine("SelectMany_Indexed 查询表达式");
            //o.OrderDate >= cutoffDate
            //var result = from c in customers
            //             where c.Region == "WA"
            //             from o in c.Orders
            //             where o.OrderDate >= cutoffDate
            //             select new { c.CustomerID, o.OrderID };
            //Print(result);
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
