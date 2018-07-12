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
            //Select_Filtered linq13 = new Select_Filtered();
            //linq13.Show();
            //linq13.Show(0);
            #endregion

            #region SelectMany_Compound_from_1
            //SelectMany_Compound_from_1 linq14 = new SelectMany_Compound_from_1();
            //linq14.Show();
            //linq14.Show(0);
            #endregion

            #region SelectMany_Compound_from_2
            //SelectMany_Compound_from_2 linq15 = new SelectMany_Compound_from_2();
            //linq15.Show();
            //linq15.Show(0);
            #endregion

            #region SelectMany_Compound_from_3
            //SelectMany_Compound_from_3 linq16 = new SelectMany_Compound_from_3();
            //linq16.Show();
            //linq16.Show(0);
            #endregion

            #region SelectMany_from_Assignment
            //SelectMany_from_Assignment linq17 = new SelectMany_from_Assignment();
            //linq17.Show();
            //linq17.Show(0);
            #endregion

            #region SelectMany_Muliple_from
            //SelectMany_Muliple_from linq18 = new SelectMany_Muliple_from();
            //linq18.Show();
            //linq18.Show(0);
            #endregion

            #region SelectMany_Indexed
            //SelectMany_Indexed linq19 = new SelectMany_Indexed();
            //linq19.Show();
            //linq19.Show(0);
            #endregion

            #region Take_Simple
            //Take_Simple linq20 = new Take_Simple();
            //linq20.Show();
            //linq20.Show(0);
            #endregion

            #region Take_Nested
            //Take_Nested linq21 = new Take_Nested();
            //linq21.Show();
            //linq21.Show(0);
            #endregion

            #region Skip_Simple
            //Skip_Simple linq22 = new Skip_Simple();
            //linq22.Show();
            //linq22.Show(0);
            #endregion

            #region Skip_Nested
            //Skip_Nested linq23 = new Skip_Nested();
            //linq23.Show();
            //linq23.Show(0);
            #endregion

            #region TakeWhile_Simple
            //TakeWhile_Simple linq24 = new TakeWhile_Simple();
            //linq24.Show();
            //linq24.Show(0);
            #endregion

            #region SkipWhile_Simple
            //SkipWhile_Simple linq25 = new SkipWhile_Simple();
            //linq25.Show();
            //linq25.Show(0);
            #endregion

            #region TakeWhile_Index
            //TakeWhile_Index linq26 = new TakeWhile_Index();
            //linq26.Show();
            //linq26.Show(0);
            #endregion

            #region SkipWhile_Index
            //SkipWhile_Index linq27 = new SkipWhile_Index();
            //linq27.Show();
            //linq27.Show(0);
            #endregion

            #region OrderBy_SImple_1
            //OrderBy_SImple_1 linq28 = new OrderBy_SImple_1();
            //linq28.Show();
            //linq28.Show(0);
            #endregion

            #region OrderBy_SImple_2
            //OrderBy_SImple_2 linq29 = new OrderBy_SImple_2();
            //linq29.Show();
            //linq29.Show(0);
            #endregion

            #region OrderBy_SImple_3
            //OrderBy_SImple_3 linq30 = new OrderBy_SImple_3();
            //linq30.Show();
            //linq30.Show(0);
            #endregion


            #region OrderBy_Comparer
            //OrderBy_Comparer linq31 = new OrderBy_Comparer();
            //linq31.Show();
            //linq31.Show(0);
            #endregion

            #region OrderByDescending_SImple_1
            //OrderByDescending_SImple_1 linq32 = new OrderByDescending_SImple_1();
            //linq32.Show();
            //linq32.Show(0);
            #endregion

            #region OrderByDescending_SImple_2
            //OrderByDescending_SImple_2 linq33 = new OrderByDescending_SImple_2();
            //linq33.Show();
            //linq33.Show(0);
            #endregion

            #region OrderByDescending_Comparer
            OrderByDescending_Comparer linq34 = new OrderByDescending_Comparer();
            linq34.Show();
            linq34.Show(0);
            #endregion

            #endregion

            Console.Read();
        }

    }


}
