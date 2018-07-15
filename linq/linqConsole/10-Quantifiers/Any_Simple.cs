using System;
using System.Collections.Generic;
using System.Linq;


namespace linqConsole
{
    public class Any_Simple
    {
        public void Show()
        {
            string[] words = { "believe", "relief", "receipt", "field" };
            bool iAfterE = words.Any(x => x.Contains("ei"));
            Console.WriteLine($"There is a word that contains in the list that contains 'ei': {iAfterE}");
        }
    }
}
