using System;
using System.Collections.Generic;
using System.Linq;

namespace linqConsole
{
    public class First_Indexed
    {
        public void Show()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int evenNum = numbers.Where((nums,index)=>(nums%2==0)&&(index%2==0)).First();
            Console.WriteLine("{0} is an even number at an even position within the list.", evenNum);
        }
    }
}
