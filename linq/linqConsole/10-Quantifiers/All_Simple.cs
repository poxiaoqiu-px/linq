﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class All_Simple
    {
        public void Show()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
            bool onlyOdd = numbers.All(n => n % 2 == 1);
            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
        }
    }
}
