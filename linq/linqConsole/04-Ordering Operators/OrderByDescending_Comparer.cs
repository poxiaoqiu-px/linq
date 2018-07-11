using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class OrderByDescending_Comparer
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine();
            Console.WriteLine("OrderByDescending_Comparer 点标记");
            //First numbers less than 6:
            var result = words.OrderByDescending(x => x,new CaseInsensitiveComparer());
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
            Console.WriteLine("OrderByDescending_Comparer 查询表达式");
            //First 3 numbers:
            var result = from c in words
                         orderby (c,new CaseInsensitiveComparer()) descending
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


    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }
    }

}
