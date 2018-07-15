using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Any_Indexed
    {
        public void Show()
        {
            int[] numbers = { -9, -4, -8, -3, -5, -2, -1, -6, -7 };
            bool negativeMatch = numbers.Where((n, index) => (n == -index)).Any(); 
            Console.WriteLine($"There is a number that is the negative of its index: {negativeMatch}");
        }
    }
}
