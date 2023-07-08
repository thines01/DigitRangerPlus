using System;
//
namespace DigitRangerPlus
{
   using PaniBase;
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      public static Func<CPaniBase, CPaniBase, bool> IsLowerLow = (p1, p2) => p1.ulngLow < p2.ulngLow;
      public static Func<CPaniBase, CPaniBase, bool> IsUpperHigh = (p1, p2) => p1.ulngHigh > p2.ulngHigh;
      public static Func<CPaniBase, CPaniBase, string> GetLowerDiff = (p1Lower, p2Higher) => p1Lower.strLow + '-' + (p2Higher.ulngLow - 1).ToString("D10");
      public static Func<CPaniBase, CPaniBase, string> GetUpperDiff = (p1Higher, p2Lower) => (p2Lower.ulngHigh + 1).ToString("D10") + '-' + p1Higher.strHigh;
   }
}