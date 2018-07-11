using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class SelectMany_Compound_from_3
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {

            Console.WriteLine();
            Console.WriteLine("SelectMany_Compound_from_3 点标记");
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
            Console.WriteLine("SelectMany_Compound_from_3 查询表达式");
            //o.OrderDate >= new DateTime(1998, 1, 1)
            var result = from a in customers
                         from o in a.Orders
                         where o.OrderDate > new DateTime(1998, 1, 1)
                         select new { a.CustomerID, o.OrderID, OrderDate = o.OrderDate.ToString("yyyy-MM-dd") };
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
