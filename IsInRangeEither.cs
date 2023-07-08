namespace DigitRangerPlus
{
   using DigitRanger;
   using PaniBase;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      public static bool IsInRangeEither(CPaniBase paniLeft, CPaniBase paniRight)
      {
         return IsInRangeEither(paniLeft.ulngLow, paniLeft.ulngHigh, paniRight.ulngLow, paniRight.ulngHigh);
      }
   }
}