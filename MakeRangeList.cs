using System.Collections.Generic;
//
namespace DigitRangerPlus
{
   using RangeObj;
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      /// <summary>
      /// Converts a string containing Ranges to a List&lt;CRange&gt;
      /// </summary>
      /// <param name="strRange"></param>
      /// <returns></returns>
      private static List<CRange> MakeRangeList(string strRange)
      {
         List<CRange> lst_ran = new List<CRange>();
         string[] arr_str = strRange.Split(',');
         foreach (string s in arr_str)
         {
            lst_ran.Add(new CRange(s));
         }
         return lst_ran;
      }

      /// <summary>
      /// Converts a list of strings containg Ranges to a List&lt;CRange&gt;
      /// </summary>
      /// <param name="lst_strRanges"></param>
      /// <returns></returns>
      private static List<CRange> MakeRangeList(List<string> lst_strRanges)
      {
         List<CRange> lst_ran = new List<CRange>();
         foreach (string s in lst_strRanges)
         {
            lst_ran.Add(new CRange(s));
         }
         return lst_ran;
      }
   }
}