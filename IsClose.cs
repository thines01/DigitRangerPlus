namespace DigitRangerPlus
{
   using DigitRanger;
   public partial class CDigitRangerPlus : CDigitRanger
   {
      /// <summary>
      /// Checks to see if a given number is within the gap
      /// </summary>
      /// <param name="ulngFirst">Any number</param>
      /// <param name="ulngSecond">...number to test</param>
      /// <param name="ulngGap">GAP</param>
      /// <returns></returns>
      public static bool IsClose(ulong ulngFirst, ulong ulngSecond, ulong ulngGap)
      {
         return ((ulngSecond - ulngFirst) <= ulngGap);
      }
   }
}