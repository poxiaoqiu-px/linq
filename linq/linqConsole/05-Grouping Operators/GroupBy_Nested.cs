using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class GroupBy_Nested
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var list = new ProductList();
            var customers = list.GetCustomerList();
            Console.WriteLine();
            Console.WriteLine("GroupBy_Nested 点标记");
            //n % 5
            //var result = products.GroupBy(g => g.Category).Select(g => new { Category = g.Key, products = g });
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
            Console.WriteLine("GroupBy_Nested 查询表达式");
            //n % 5
            var result = (from w in customers
                         select new { 
                w.CompanyName,YearGroups=from o in w.Orders
                    group o by o.OrderDate.Year into yg
                    select new {
                    Year=yg.Key,
                    MonthGroups=from o in yg 
                        group o by o.OrderDate.Month into mg
                                    select new {Month=mg.Key,Orders=mg}
                }
            }).ToList();

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
