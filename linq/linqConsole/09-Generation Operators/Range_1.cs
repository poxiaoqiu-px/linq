using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Range_1
    {
        public void Show()
        {
            var numbers = 
                from n in Enumerable.Range(100, 50) 
                          select new { Numbers = n, OldEven = n % 2 == 1 ? "odd" : "even" };
            foreach (var n in numbers)
            {
                Console.WriteLine($"The number {n.Numbers} is {n.OldEven}.");
            }
        }
    }
}
