namespace DigitRangerPlus
{
   using RangeObj;
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      /// <summary>
      /// Checks to see if a target number fits inside of a range or is
      /// contiguous to the range on either end.
      /// </summary>
      /// <param name="strOrigRanges">One or many formatted ranges separated by commas</param>
      /// <param name="strTarget">The target digits string</param>
      /// <returns>bool: true if target borders the ranges</returns>
      public static bool Borders(string strOrigRanges, string strTarget)
      {
         bool blnRetVal = false;
         ulong ulngTarget = ulong.Parse(strTarget);
         ulong ulngLow = 0;
         ulong ulngHigh = 0;

         string[] arr_strRanges = strOrigRanges.Split(',');//do not List<>

         foreach (string strRange in arr_strRanges)
         {
            CRange ran = new CRange(strRange);
            ulngLow = ulong.Parse(ran.strLow);
            ulngHigh = ulong.Parse(ran.strHigh);

            if (
               IsInRange(ulngLow, ulngHigh, ulngTarget)
               || IsInRange(ulngLow, ulngHigh, (ulngTarget + 1))
               || IsInRange(ulngLow, ulngHigh, (ulngTarget - 1))
               )
            {
               blnRetVal = true;
               break;
            }
         }

         return blnRetVal;
      }
   }
}