using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class GroupBy_Comparer_Mapped
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] anagrams = {"from ", " salt", " earn ", " last ", " near ", " form "}; 
            Console.WriteLine();
            Console.WriteLine("GroupBy_Comparer_Mapped 点标记");
            //n % 5
            var result = anagrams.GroupBy(g => g.Trim(),a=>a.ToUpper(),new AnagramEqualityComparer());
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            string[] anagrams = {"from ", " salt", " earn ", " last ", " near ", " form "}; 
            Console.WriteLine();
            Console.WriteLine("GroupBy_Comparer_Mapped 查询表达式");
            //n % 5
            var result = from w in anagrams
                         group w by (w.Trim(),w.ToUpper(), new AnagramEqualityComparer()) into g
                         select g;
                                        
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
