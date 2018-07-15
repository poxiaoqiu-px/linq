using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Count_Indexed
    {
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.Where((x,index) => x % 2 == index%2).Count();
            Console.WriteLine(result);

        }
    }
}
