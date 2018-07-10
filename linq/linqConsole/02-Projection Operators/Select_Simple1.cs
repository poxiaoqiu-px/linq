using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Select_Simple1
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine();
            Console.WriteLine("SSelect_Simple1 点标记");
            //Numbers + 1
            var result = numbers.Select(t => t + 1);
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
            Console.WriteLine("Select_Simple1 查询表达式");
            //Customers from Washington and their orders:
            var result = from t in numbers
                         select t+1;
            Print(result);
        }

        private void Print(IEnumerable<int> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
        }
    }




}
