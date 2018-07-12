using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class OfType
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            object[] numbers = { null, 1.0, "two", 3, 4.0f, 5, "six", 7.0 };
            var doubles = numbers.OfType<double>();
            Console.WriteLine("Numbers stored as doubles:");
            foreach (var d in doubles)
            {
                Console.WriteLine(d);
            }
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            object[] numbers = { null, 1.0, "two", 3, 4.0f, 5, "six", 7.0 };
            var doubles = numbers.OfType<int>();
            Console.WriteLine("Numbers stored as int:");
            foreach (var d in doubles)
            {
                Console.WriteLine(d);
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
