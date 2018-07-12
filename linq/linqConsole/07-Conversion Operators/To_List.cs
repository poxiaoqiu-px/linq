using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class To_List
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = words.OrderBy(x=>x).ToList();
            var wordList = sortedWords.ToList();
            Console.WriteLine("The sorted word list:");
            foreach (var w in wordList)
            {
                Console.WriteLine(w);
            }
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords =
                from w in words
                orderby w
                select w;
            var wordList = sortedWords.ToList();
            Console.WriteLine("The sorted word list:");
            foreach (var w in wordList)
            {
                Console.WriteLine(w);
            }
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
