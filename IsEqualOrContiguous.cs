namespace DigitRangerPlus
{
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      public static bool IsEqualOrContiguous(double dblPrevious, double dblNext)
      {
         if (dblPrevious.Equals(dblNext))
         {
            return true;
         }

         return IsContiguous(dblPrevious, dblNext);
      }

      public static bool IsEqualOrContiguous(string strPrevious, string strNext)
      {
         if (strPrevious.Equals(strNext))
         {
            return true;
         }

         return IsContiguous(strPrevious, strNext);
      }
   }
}
