using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class Select_Anonymous_Types_1
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            Console.WriteLine();
            Console.WriteLine("Select_Anonymous_Types_1 点标记");
            //Uppercase Lowercase
            var result = words.Select(t=>new {Uppercase=t.ToUpper(),Lowercase=t.ToLower()});
            Print(result);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Select_Anonymous_Types_1 查询表达式");
            //Uppercase Lowercase
            var result = from t in words
                select new {Uppercase=t.ToUpper(),Lowercase=t.ToLower()};
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
