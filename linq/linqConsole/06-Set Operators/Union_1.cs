using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Union_1
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            Console.WriteLine();
            Console.WriteLine("Union_1 点标记");
            //Numbers < 5:
            var result = numbersA.Union(numbersB);
            Print(result);
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
            Console.WriteLine("Union_1 查询表达式");
            //Numbers < 5:
            var result = (from t in numbersA
                          select t).Union(from t in numbersB select t) ;
            Print(result);
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
