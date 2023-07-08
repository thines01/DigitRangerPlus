using System.Collections.Generic;
using System.Linq;
//
namespace DigitRangerPlus
{
   using PaniBase;
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      public static List<CPaniBase> GetUnmatchedRanges(CPaniBase baseMaster, CPaniBase baseSecond)
      {
         return MergeUnmatchedRanges(
            new List<KeyValuePair<CPaniBase, CPaniBase>> { new KeyValuePair<CPaniBase, CPaniBase>(baseMaster, baseSecond) }
            .Where(pbp => CDigitRangerPlus.IsInRangeEither(pbp.Key, pbp.Value) && !CDigitRangerPlus.Equals(pbp.Key.ToString(), pbp.Value.ToString()))
            .ToList());
      }
   }
}