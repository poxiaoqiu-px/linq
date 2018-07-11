using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class SelectMany_Compound_from_1
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            Console.WriteLine();
            Console.WriteLine("SelectMany_Compound_from_1 点标记");
            //Pairs where a < b:
            //var result = ;
            //Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            Console.WriteLine();
            Console.WriteLine("SelectMany_Compound_from_1 查询表达式");
            //Pairs where a < b:
            var result = from a in numbersA
                         from b in numbersB
                         where a < b
                         select new { a, b };
            Print(result);
        }

        private void Print(IEnumerable<object> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }




}
