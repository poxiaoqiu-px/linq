using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace linqConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Where_Simple1
            Where_Simple1 simple1 = new Where_Simple1();
            simple1.Show();
            simple1.Show(0);
            #endregion

            #region Where_Simple2
            Where_Simple2 simple2 = new Where_Simple2();
            simple2.Show();
            simple2.Show(0);
            #endregion

            Console.Read();
        }
        
    }


}
