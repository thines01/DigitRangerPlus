using System.Collections.Generic;
using System.Linq;
//
namespace DigitRangerPlus
{
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      /// <summary>
      /// Returns a merged range with a given target number string
      /// </summary>
      /// <param name="strOrigRanges"></param>
      /// <param name="strTarget"></param>
      /// <returns></returns>
      public static string GetMergedRange(string strOrigRanges, string strTarget)
      {
         if (!Borders(strOrigRanges, strTarget))
         {
            return strOrigRanges + "," + strTarget;
         }

         List<string> lst_strRanges = strOrigRanges.Split(',').ToList();
         lst_strRanges.Add(strTarget + "-" + strTarget);

         return Collapse(lst_strRanges);
      }
   }
}