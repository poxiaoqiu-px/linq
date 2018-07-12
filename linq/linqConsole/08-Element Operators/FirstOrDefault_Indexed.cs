using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linqConsole
{
    public class FirstOrDefault_Indexed
    {
        public void   Show()
        {
            double?[] doubles = { 1.7, 2.3, 4.1, 1.9, 2.9 };
            double? num = doubles.Where((n, index) => (n >= index - 0.5 && n <= index + 0.5)).FirstOrDefault();
            if (num != null)
                Console.WriteLine("The value {0} is within 0.5 of its index position.", num);
            else
                Console.WriteLine("There is {0} number within 0.5 of its index position.", num);
        }
    }
}
