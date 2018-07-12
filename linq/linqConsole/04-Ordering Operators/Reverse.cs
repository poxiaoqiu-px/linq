using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Reverse
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine();
            Console.WriteLine("Reverse 点标记");
            //Sorted digits:
            var result = digits.Where(x => x[1] == 'i').Reverse();
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine();
            Console.WriteLine("Reverse 查询表达式");
            //Sorted digits:
            var result = (from c in digits
                          where c[1] == 'i'
                          select c).Reverse();
                            
                           
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
