using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class OrderByDescending_SImple_1
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            Console.WriteLine();
            Console.WriteLine("OrderByDescending_SImple_1 点标记");
            //First numbers less than 6:
            var result = doubles.OrderByDescending(x=>x);
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            Console.WriteLine();
            Console.WriteLine("OrderByDescending_SImple_1 查询表达式");
            //First 3 numbers:
            var result = from c in doubles
                         orderby c descending
                         select c;
                           
            Print(result);
        }

        private void Print(IEnumerable<double> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }




}
