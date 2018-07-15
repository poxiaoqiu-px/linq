using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Count_Conditional
    {
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.Count(x => x % 2 == 1);
            Console.WriteLine(result);

        }
    }
}
