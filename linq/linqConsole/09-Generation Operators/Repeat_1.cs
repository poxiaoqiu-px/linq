using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Repeat_1
    {
        public void Show()
        {
            var numbers =
                 Enumerable.Repeat(7, 10);
                         
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
