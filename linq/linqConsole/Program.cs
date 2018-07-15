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
            //OrderByDescending_Comparer linq34 = new OrderByDescending_Comparer();
            //linq34.Show();
            //linq34.Show(0);
            #endregion

            #region ThenBy_SImple
            //ThenBy_SImple linq35 = new ThenBy_SImple();
            //linq35.Show();
            //linq35.Show(0);
            #endregion

            #region ThenBy_Comparer
            //ThenBy_Comparer linq36 = new ThenBy_Comparer();
            //linq36.Show();
            //linq36.Show(0);
            #endregion

            #region ThenByDescending_SImple
            //ThenByDescending_SImple linq37 = new ThenByDescending_SImple();
            //linq37.Show();
            //linq37.Show(0);
            #endregion

            #region ThenByDescending_Comparer
            //ThenByDescending_Comparer linq38 = new ThenByDescending_Comparer();
            //linq38.Show();
            //linq38.Show(0);
            #endregion

            #region Reverse
            //Reverse linq39 = new Reverse();
            //linq39.Show();
            //linq39.Show(0);
            #endregion

            #region GroupBy_Simple_1
            //GroupBy_Simple_1 linq40 = new GroupBy_Simple_1();
            //linq40.Show();
            //linq40.Show(0);
            #endregion

            #region GroupBy_Simple_2
            //GroupBy_Simple_2 linq41 = new GroupBy_Simple_2();
            //linq41.Show();
            //linq41.Show(0);
            #endregion

            #region GroupBy_Simple_3
            //GroupBy_Simple_3 linq42 = new GroupBy_Simple_3();
            //linq42.Show();
            //linq42.Show(0);
            #endregion

            #region GroupBy_Nested
            //GroupBy_Nested linq43 = new GroupBy_Nested();
            //linq43.Show();
            //linq43.Show(0);
            #endregion

            #region GroupBy_Comparer
            //GroupBy_Comparer linq44 = new GroupBy_Comparer();
            //linq44.Show();
            //linq44.Show(0);
            #endregion

            #region GroupBy_Comparer_Mapped
            //GroupBy_Comparer_Mapped linq45 = new GroupBy_Comparer_Mapped();
            //linq45.Show();
            //linq45.Show(0);
            #endregion

            #region Distinct_1
            //Distinct_1 linq46 = new Distinct_1();
            //linq46.Show();
            //linq46.Show(0);
            #endregion

            #region Distinct_2
            //Distinct_2 linq47 = new Distinct_2();
            //linq47.Show();
            //linq47.Show(0);
            #endregion

            #region Union_1
            //Union_1 linq48 = new Union_1();
            //linq48.Show();
            //linq48.Show(0);
            #endregion

            #region Union_2
            //Union_2 linq49 = new Union_2();
            //linq49.Show();
            //linq49.Show(0);
            #endregion

            #region Intersect_1
            //Intersect_1 linq50 = new Intersect_1();
            //linq50.Show();
            //linq50.Show(0);
            #endregion

            #region Intersect_2
            //Intersect_2 linq51 = new Intersect_2();
            //linq51.Show();
            //linq51.Show(0);
            #endregion


            #region Except_1
            //Except_1 linq52 = new Except_1();
            //linq52.Show();
            //linq52.Show(0);
            #endregion

            #region Except_2
            //Except_2 linq53 = new Except_2();
            //linq53.Show();
            //linq53.Show(0);
            #endregion

            #region To_Array
            //To_Array linq54 = new To_Array();
            //linq54.Show();
            //linq54.Show(0);
            #endregion

            #region To_List
            //To_List linq55 = new To_List();
            //linq55.Show();
            //linq55.Show(0);
            #endregion

            #region To_Dictionary
            //To_Dictionary linq56 = new To_Dictionary();
            //linq56.Show();
            //linq56.Show(0);
            #endregion


            #region OfType
            //OfType linq57 = new OfType();
            //linq57.Show();
            //linq57.Show(0);
            #endregion

            #region First_Simple
            //First_Simple linq58 = new First_Simple();
            //linq58.Show();
            #endregion

            #region First_Indexed
            //First_Indexed linq60 = new First_Indexed();
            //linq60.Show();
            #endregion

            #region FirstOrDefault_Simple
            //FirstOrDefault_Simple linq61 = new FirstOrDefault_Simple();
            //linq61.Show();
            #endregion

            #region FirstOrDefault_Condition
            //FirstOrDefault_Condition linq62 = new FirstOrDefault_Condition();
            //linq62.Show();
            #endregion

            #region FirstOrDefault_Indexed
            //FirstOrDefault_Indexed linq63 = new FirstOrDefault_Indexed();
            //linq63.Show();
            #endregion

            #region ElementAt
            //ElementAt linq64 = new ElementAt();
            //linq64.Show();
            #endregion

            #region Range
            //Range_1 linq65 = new Range_1();
            //linq65.Show();
            #endregion

            #region Repeat
            //Repeat_1 linq66 = new Repeat_1();
            //linq66.Show();
            #endregion

            #region Any_Simple
            //Any_Simple linq67 = new Any_Simple();
            //linq67.Show();
            #endregion

            #region Any_Indexed
            //Any_Indexed linq68 = new Any_Indexed();
            //linq68.Show();
            #endregion

            #region Any_Group
            Any_Group linq69 = new Any_Group();
            linq69.Show();
            #endregion

            #region All_Simple
            //All_Simple linq70 = new All_Simple();
            //linq70.Show();
            #endregion

            #region All_Indexed
            //All_Indexed linq71 = new All_Indexed();
            //linq71.Show();
            #endregion

            #region All_Group
            //All_Group linq72 = new All_Group();
            //linq72.Show();
            #endregion

            #region Count_Simple
            //Count_Simple linq73 = new Count_Simple();
            //linq73.Show();
            #endregion

            //#region Count_Conditional
            //Count_Conditional linq74 = new Count_Conditional();
            //linq74.Show();
            //#endregion

            #region Count_Indexed
            //Count_Indexed linq75 = new Count_Indexed();
            //linq75.Show();
            #endregion

            #region Count_Nested
            //Count_Nested linq76 = new Count_Nested();
            //linq76.Show();
            #endregion

            #region Count_Group
            Count_Group linq77 = new Count_Group();
            linq77.Show();
            #endregion

            #endregion

            Console.Read();
        }

    }


}
