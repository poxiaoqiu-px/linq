using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class OrderBy_SImple_2
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            Console.WriteLine();
            Console.WriteLine("OrderBy_SImple_2 点标记");
            //First numbers less than 6:
            var result = words.OrderBy(x=>x.Length);
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            string[] words = { "cherry", "apple", "blueberry" };
            Console.WriteLine();
            Console.WriteLine("OrderBy_SImple_2 查询表达式");
            //First 3 numbers:
            var result = from c in words
                         orderby c.Length
                         select c;
                           
            Print(result);
        }

        private void Print(IEnumerable<string> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }




}
