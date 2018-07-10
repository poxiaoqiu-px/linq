using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Where_Indexed
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine();
            Console.WriteLine("Where_Indexed 点标记");
            //Short digits:
            var result = digits.Where((digit,index)=>digit.Length<index);
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
           
        }

        private void Print(IEnumerable<string> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine($"The word {item} is shorter than its value.");
            }
        }
    }




}
