using System.Collections.Generic;
using System.Linq;
//
namespace DigitRangerPlus
{
   using RangeObj;
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      /// <summary>
      /// Determines if ANY of the values exist in both ranges.
      /// </summary>
      /// <param name="lst_r1">List of PANI Ranges</param>
      /// <param name="lst_r2">List of PANI Ranges</param>
      /// <returns>bool: true if matched</returns>
      public static bool IsMatch(List<CRange> lst_r1, List<CRange> lst_r2)
      {
         return (
            from r1 in lst_r1
            where lst_r2.Any(r2 =>
               CDigitRanger.IsInRangeEither(
                  ulong.Parse(r2.strLow),
                  ulong.Parse(r2.strHigh),
                  ulong.Parse(r1.strLow),
                  ulong.Parse(r1.strHigh)
                  )
               )
            select r1
         ).Any();
      }

      /// <summary>
      /// Compares two string ranges using (IsInRangeEither())
      /// </summary>
      /// <param name="strRange1"></param>
      /// <param name="strRange2"></param>
      /// <returns></returns>
      public static bool IsMatch(string strRange1, string strRange2)
      {
         List<CRange> lst1 = MakeRangeList(strRange1);
         List<CRange> lst2 = MakeRangeList(strRange2);
         return IsMatch(lst1, lst2);
      }

      /// <summary>
      /// Compares two List&lt;string&gt; containing ranges using(IsInRangeEither())
      /// </summary>
      /// <param name="lst_str1"></param>
      /// <param name="lst_str2"></param>
      /// <returns></returns>
      public static bool IsMatch(List<string> lst_str1, List<string> lst_str2)
      {
         List<CRange> lst1 = MakeRangeList(lst_str1);
         List<CRange> lst2 = MakeRangeList(lst_str2);
         return IsMatch(lst1, lst2);
      }
   }
}