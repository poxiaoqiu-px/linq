using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class ThenByDescending_Comparer
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine();
            Console.WriteLine("ThenByDescending_Comparer 点标记");
            //Sorted digits:
            var result = words.OrderBy(x=>x.Length).ThenByDescending(x=>x,new CaseInsensitiveComparer());
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine();
            Console.WriteLine("ThenByDescending_Comparer 查询表达式");
            //Sorted digits:
            var result = from c in words
                         orderby c.Length,(c,new CaseInsensitiveComparer()) descending
                         select c;
                           
            Print(result);
        }

        private void Print(IEnumerable<string> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }




}
