using System;
using System.Collections.Generic;
using System.Linq;
//
namespace DigitRangerPlus
{
   using PaniBase;
   using KVP_P2P = KeyValuePair<Func<PaniBase.CPaniBase, PaniBase.CPaniBase, bool>, Func<PaniBase.CPaniBase, PaniBase.CPaniBase, string>>;
   
   using DigitRanger;

   public partial class CDigitRangerPlus : CDigitRanger
   {
      private static KVP_P2P kvp_prdLow = new KVP_P2P(CDigitRangerPlus.IsLowerLow, CDigitRangerPlus.GetLowerDiff);
      private static KVP_P2P kvp_prdHigh = new KVP_P2P(CDigitRangerPlus.IsUpperHigh, CDigitRangerPlus.GetUpperDiff);

      private static Func<List<KeyValuePair<CPaniBase, CPaniBase>>, KVP_P2P, List<CPaniBase>> GetTargetPaniBase = (lst_pbUnmatched, kvp_prd) =>
         lst_pbUnmatched.Where(pbu => kvp_prd.Key(pbu.Key, pbu.Value))
            .Select(pbu => new CPaniBase(kvp_prd.Value(pbu.Key, pbu.Value)))
               .ToList();
      
      private static Func<List<KeyValuePair<CPaniBase, CPaniBase>>, List<CPaniBase>> MergeUnmatchedRanges = lst_pbUnmatched =>
         GetTargetPaniBase(lst_pbUnmatched, kvp_prdLow)
            .Union(GetTargetPaniBase(lst_pbUnmatched, kvp_prdHigh))
               .ToList();
   }
}