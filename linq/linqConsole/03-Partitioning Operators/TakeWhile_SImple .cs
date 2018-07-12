﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class TakeWhile_Simple
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine();
            Console.WriteLine("TakeWhile_Simple 点标记");
            //First numbers less than 6:
            var result = numbers.TakeWhile(x => x < 6);
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
            Console.WriteLine("TakeWhile_Simple 查询表达式");
            //First 3 numbers:
            var result = (from c in numbers
                          select c
                         )
                //.OrderBy(c=>Guid.NewGuid())  
                .TakeWhile(c => c < 6);
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
