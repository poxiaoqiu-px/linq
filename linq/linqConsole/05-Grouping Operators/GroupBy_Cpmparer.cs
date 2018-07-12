using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class GroupBy_Comparer
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] anagrams = {"from ", " salt", " earn ", " last ", " near ", " form "}; 
            Console.WriteLine();
            Console.WriteLine("GroupBy_Comparer 点标记");
            //n % 5
            var result = anagrams.GroupBy(g => g.Trim(),new AnagramEqualityComparer());
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
            Console.WriteLine("GroupBy_Comparer 查询表达式");
            //n % 5
            var result = from w in anagrams
                         group w by (w.Trim(), new AnagramEqualityComparer()) into g
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


    public class AnagramEqualityComparer : IEqualityComparer<string> 
{ 
public bool Equals(string x, string y) { return getCanonicalString(x) == getCanonicalString(y); } 
public int GetHashCode(string obj) { return getCanonicalString(obj).GetHashCode(); } 
private string getCanonicalString(string word) 
{ 
    char[] wordChars = word.ToCharArray(); Array.Sort(wordChars); return new string(wordChars); 
} 
} 

}
