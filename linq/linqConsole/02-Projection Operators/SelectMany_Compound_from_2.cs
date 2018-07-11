using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class SelectMany_Compound_from_2
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
           
            Console.WriteLine();
            Console.WriteLine("SelectMany_Compound_from_2 点标记");
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
            Console.WriteLine("SelectMany_Compound_from_2 查询表达式");
            //o.Total < 500.00M
            var result = from a in customers
                         from o in a.Orders
                         where o.Total<500M
                                    select new { a.CustomerID,o.OrderID,OrderDate=o.OrderDate.ToString("yyyy-MM-dd") };
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
