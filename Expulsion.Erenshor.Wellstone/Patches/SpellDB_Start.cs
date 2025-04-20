using HarmonyLib;
using UnityEngine;

namespace Expulsion.Erenshor.Wellstone.Patches
{
    [HarmonyPatch(typeof(SpellDB), "Start")]
    public class SpellDB_Start
    {
        public static void Postfix(SpellDB __instance)
        {
            var spellWellstone = Object.Instantiate(__instance.GetSpellByID("49559349"));
            spellWellstone.Id = "Expulsion.Wellstone";
            spellWellstone.name = "ALL - WELLSTONE";
            spellWellstone.SpellName = "Wellstone";
            spellWellstone.SpellDesc = "Teleports to your last Wishing Well location.";
            spellWellstone.ManaCost = 0;
            spellWellstone.SimUsable = false;
            spellWellstone.RequiredLevel = 1;

            Plugin.Log?.LogInfo("Adding Wellstone to SpellDB of ID: " + spellWellstone.Id);
            __instance.SpellDatabase = __instance.SpellDatabase.AddToArray(spellWellstone);
        }
    }
}