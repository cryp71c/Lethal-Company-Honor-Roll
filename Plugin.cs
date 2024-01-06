using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonorRoll
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class HonorRoll
    {
        private const string modGUID = "cryp71c.honor.roll";
        private const string modName = "Honor Roll";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static HonorRoll instance;

        internal ManualLogSource mls;

        void Awake() {
            if (instance == null) { 
                instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            harmony.PatchAll(typeof(HonorRoll));


        }
    }
}
