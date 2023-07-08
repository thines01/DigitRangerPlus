using System.Collections.Generic;
using System.Linq;
//
namespace DigitRangerPlus
{
   using RangeObj;
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      public static bool IsContiguous(double dblPrevious, double dblNext)
      {
         return (dblPrevious + 1).Equals(dblNext);
      }

      public static bool IsContiguous(string strPrevious, string strNext)
      {
         double dblPrevious = double.Parse(strPrevious.PadLeft(1, '0'));
         double dblNext = double.Parse(strNext.PadLeft(1, '0'));

         return IsContiguous(dblPrevious, dblNext);
      }
   }
}