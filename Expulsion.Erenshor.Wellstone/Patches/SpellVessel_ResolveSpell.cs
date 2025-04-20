using HarmonyLib;

namespace Expulsion.Erenshor.Wellstone.Patches
{
    [HarmonyPatch(typeof(SpellVessel), "ResolveSpell")]
    public class SpellVessel_ResolveSpell
    {
        public static void Postfix(SpellVessel __instance)
        {
            if (__instance.spell.Id == "Expulsion.Wellstone")
            {
                SimPlayerDataManager.SaveAllSimData();
                GameData.SceneChange.ChangeScene(GameData.BindZone, GameData.BindLoc, GameData.SunInBindZone, 180f);
            }
        }
    }
}