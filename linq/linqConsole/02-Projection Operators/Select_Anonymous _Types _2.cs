using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Select_Anonymous_Types_2
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine();
            Console.WriteLine("Select_Anonymous_Types_2 点标记");
            //The digit {0} is {1}.
            var result = numbers.Select(t=>new {Digit=strings[t],Even=(t%2==0)});
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine();
            Console.WriteLine("Select_Anonymous_Types_2 查询表达式");
            //The digit {0} is {1}.
            var result = from t in numbers
                select new {Digit=strings[t],Even = (t % 2 == 0)};
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
