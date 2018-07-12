using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class GroupBy_Simple_1
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine();
            Console.WriteLine("GroupBy_Simple_1 点标记");
            //n % 5
            var result = numbers.GroupBy(x => x % 5).Select(g => new { Remainder = g.Key, Numbers = g.Sum() });
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine();
            Console.WriteLine("GroupBy_Simple_1 查询表达式");
            //n % 5
            var result = from n in numbers
                         group n by n % 5 into g
                         select new { Remainder = g.Key, Numbers = g.Sum() };

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
