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
            #region Where
            #region Where_Simple1
            //Where_Simple1 linq1 = new Where_Simple1();
            //linq1.Show();
            //linq1.Show(0);
            #endregion

            #region Where_Simple2
            //Where_Simple2 linq2 = new Where_Simple2();
            //linq2.Show();
            //linq2.Show(0);
            #endregion

            #region Where_Simple3
            //Where_Simple3 linq3 = new Where_Simple3();
            //linq3.Show();
            //linq3.Show(0);
            #endregion

            #region Where_Drilldown
            //Where_Drilldown linq4 = new Where_Drilldown();
            //linq4.Show();
            //linq4.Show(0);
            #endregion

            #region Where_Indexed
            //Where_Indexed linq5 = new Where_Indexed();
            //linq5.Show();
            //linq5.Show(0);
            #endregion
            #endregion

            #region Select
            #region Select_Simple1
            //Select_Simple1 linq6 = new Select_Simple1();
            //linq6.Show();
            //linq6.Show(0);
            #endregion

            #region Select_Simple2
            //Select_Simple2 linq7 = new Select_Simple2();
            //linq7.Show();
            //linq7.Show(0);
            #endregion

            #region Select_Transformation
            //Select_Transformation linq8 = new Select_Transformation();
            //linq8.Show();
            //linq8.Show(0);
            #endregion

            #region Select_Anonymous_Types_1
            //Select_Anonymous_Types_1 linq9 = new Select_Anonymous_Types_1();
            //linq9.Show();
            //linq9.Show(0);
            #endregion

            #region Select_Anonymous_Types_2
            //Select_Anonymous_Types_2 linq10 = new Select_Anonymous_Types_2();
            //linq10.Show();
            //linq10.Show(0);
            #endregion

            #region Select_Anonymous_Types_3
            //Select_Anonymous_Types_3 linq11 = new Select_Anonymous_Types_3();
            //linq11.Show();
            //linq11.Show(0);
            #endregion

            #region Select_Indexed
            //Select_Indexed linq12 = new Select_Indexed();
            //linq12.Show();
            //linq12.Show(0);
            #endregion

            #region Select_Filtered
            Select_Filtered linq13 = new Select_Filtered();
            linq13.Show();
            linq13.Show(0);
            #endregion

            #endregion

            Console.Read();
        }

    }


}
