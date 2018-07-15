using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Count_Simple
    {
        public void Show()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            var result = factorsOf300.Distinct().Count();
            Console.WriteLine(result);

        }
    }
}
