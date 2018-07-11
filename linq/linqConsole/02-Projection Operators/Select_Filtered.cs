using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Select_Filtered
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine();
            Console.WriteLine("Select_Filtered 点标记");
            //Numbers < 5:
            var result = numbers.Where(t=>t<5).Select(t=>digits[t]);
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine();
            Console.WriteLine("Select_Filtered 查询表达式");
            //Numbers < 5:
            var result = from t in numbers
                         where t<5
                         select digits[t];
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
