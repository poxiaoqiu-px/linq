using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class GroupBy_Simple_2
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            Console.WriteLine();
            Console.WriteLine("GroupBy_Simple_2 点标记");
            //n % 5
            var result = words.GroupBy(x => x[0]).Select(g => new { FirstLetter = g.Key, words = g}); 
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            Console.WriteLine();
            Console.WriteLine("GroupBy_Simple_2 查询表达式");
            //n % 5
            var result = from w in words
                         group w by w[0] into g
                select new { FirstLetter = g.Key, words = g };

            Print(result);
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
