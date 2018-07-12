using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Distinct_1
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            Console.WriteLine();
            Console.WriteLine("Distinct_1 点标记");
            //Numbers < 5:
            var result = factorsOf300.Distinct();
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            Console.WriteLine();
            Console.WriteLine("Distinct_1 查询表达式");
            //Numbers < 5:
            var result = (from t in factorsOf300
                          select t).Distinct();
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
