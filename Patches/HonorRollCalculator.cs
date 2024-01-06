using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonorRoll.Patches
{
    [HarmonyPatch(typeof(RoundManager))]
    internal class HonorRollCalculator
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void honorRoll() {
            int totalScrapCollectedInQuota = RoundManager.Instance.scrapCollectedInLevel;
            float totalScrapAccrossAllRounds = RoundManager.Instance.totalScrapValueInLevel;

        }
    }
}


/*  

    NOTES:
        The RoundManager object has the scrap collected in level and total scap in level
        
        RoundManager :
            RoundManager.Instance.scrapCollectedInLevel
            RoundManager.Instance.totalScrapValueInLevel;
            
            Good place to store previous round data?

        FillEndGameStats :: Where grade is calculated
        
        StartOfRound ::
            Maybe Useful information? Havent looked yet.
 */