using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Where_Simple1
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Where_Simple1 点标记");
            //找出数组中小于5的集合并打印
            var result = numbers.Where(t => t < 5);
            foreach (var item in result)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            Console.WriteLine();
            Console.WriteLine("Where_Simple1 查询表达式");
            //找出数组中小于5的集合并打印
            var result = from t in numbers
                       where t < 5
                       select t;
            foreach (var item in result)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }

    

    
}
