using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Count_Nested
    {
        public void Show()
        {
            var list = new ProductList();
            var customers = list.GetCustomerList();
            var orderCounts =
               from c in customers
               select new { c.CustomerID, OrderCount = c.Orders.Count() };
                foreach (var item in orderCounts)
            {
                Console.WriteLine(item);
            }

        }
    }
}
