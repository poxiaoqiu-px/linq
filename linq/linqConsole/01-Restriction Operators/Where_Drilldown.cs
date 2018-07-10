using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Where_Drilldown
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var productList = new ProductList();
            var customers = productList.GetCustomerList();
            Console.WriteLine();
            Console.WriteLine("Where_Drilldown 点标记");
            //Customers from Washington and their orders:
            var result = customers.Where(t => t.Region == "WA");
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            var productList = new ProductList();
            var customers = productList.GetCustomerList();
            Console.WriteLine();
            Console.WriteLine("Where_Drilldown 查询表达式");
            //Customers from Washington and their orders:
            var result = from t in customers
                         where t.Region == "WA"
                         select t;
            Print(result);
        }

        private void Print(IEnumerable<Customer> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine($"Customer{ item.CustomerID}:{item.CompanyName}");
                foreach (var i in item.Orders)
                {
                    Console.WriteLine($"Order{i.OrderID}:{i.OrderDate}");
                }
            }
        }
    }




}
