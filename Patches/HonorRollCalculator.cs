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
            int totalScrapCollectedInQuota;
            totalScrapCollectedInQuota = RoundManager.Instance.scrapCollectedInLevel;

        }
    }
}
