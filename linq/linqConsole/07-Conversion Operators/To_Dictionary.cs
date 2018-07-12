using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqConsole
{
    public class To_Dictionary
    {
        /// <summary>
        /// 点标记
        /// </summary>
        public void Show()
        {
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                new {Name = "Bob" , Score = 40},
                                new {Name = "Cathy", Score = 45}
                              };
            var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);
            Console.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]);
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                new {Name = "Bob" , Score = 40},
                                new {Name = "Cathy", Score = 45}
                              };
            var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);
            Console.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]);
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
