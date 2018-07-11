using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Select_Indexed
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine();
            Console.WriteLine("Select_Indexed 点标记");
            //Number: In-place?"
            var result = numbers.Select((num,index)=>new { Num=num,Inplace=(num==index)});
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
            Console.WriteLine("Select_Indexed 查询表达式");
            //Number: In-place?"
            //var result = from t in numbers
            //    select new { t.ProductName, t.Category, Price = t.UnitPrice };
            //Print(result);
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
