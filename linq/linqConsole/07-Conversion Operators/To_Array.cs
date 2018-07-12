using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class To_Array
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            var sortedDoubles = doubles.OrderByDescending(x => x).ToArray();
            var doublesArray = sortedDoubles.ToArray();
            Console.WriteLine("Every other double from highest to lowest:");
            for (int d = 0; d < doublesArray.Length; d += 2)
            {
                Console.WriteLine(doublesArray[d]);
            }
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            var sortedDoubles =
                from d in doubles
                orderby d descending
                select d;
            var doublesArray = sortedDoubles.ToArray();
            Console.WriteLine("Every other double from highest to lowest:");
            for (int d = 0; d < doublesArray.Length; d += 2)
            {
                Console.WriteLine(doublesArray[d]);
            }
        }

        private void Print(IEnumerable<int> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }




}
