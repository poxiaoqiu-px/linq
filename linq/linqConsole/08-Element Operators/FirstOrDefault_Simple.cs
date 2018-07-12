using System;
using System.Collections.Generic;
using System.Linq;

namespace linqConsole
{
    public class FirstOrDefault_Simple
    {
        public void Show()
        {
            int[] numbers = { };
            int firstNumOrDefault = numbers.FirstOrDefault();
            Console.WriteLine(firstNumOrDefault);
        }
    }
}
