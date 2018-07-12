using System;
using System.Collections.Generic;
using System.Linq;

namespace linqConsole
{
    public class ElementAt
    {
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int fourthLowNum = (
                from n in numbers
                where n < 5
                select n)
                .ElementAt(3); // 3 because sequences use 0-based indexing
            Console.WriteLine("Fourth number < 5: {0}", fourthLowNum);
        }
    }
}
