using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class All_Indexed
    {
        public void Show()
        {
            int[] lowNumbers = { 1, 11, 3, 19, 41, 65, 19 };
            int[] highNumbers = { 7, 19, 42, 22, 45, 79, 24 };
            bool allLower = lowNumbers.Where((num, index) => num < highNumbers[index]).All(x=>x.Equals(1));
            Console.WriteLine("Each number in the first list is lower than its counterpart in the second list: {0}", allLower);
        }
    }
}
