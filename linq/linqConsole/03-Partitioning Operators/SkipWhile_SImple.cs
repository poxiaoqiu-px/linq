using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class SkipWhile_Simple
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine();
            Console.WriteLine("SkipWhile_Simple 点标记");
            //SkipWhile_Simple
            var result = numbers.SkipWhile(x => x % 3 != 0);
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
            Console.WriteLine("SkipWhile_Simple 查询表达式");
            //SkipWhile_Simple
            var result = (from c in numbers
                          select c
                         )
                //.OrderBy(c=>Guid.NewGuid())  
                .SkipWhile(c => c % 3 != 0);
            Print(result);
        }

        private void Print(IEnumerable<int> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }




}
