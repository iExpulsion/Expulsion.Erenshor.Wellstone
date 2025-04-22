using HarmonyLib;

namespace Expulsion.Erenshor.Wellstone.Patches
{
    [HarmonyPatch(typeof(SetBind), "SetBindPoint")]
    public class SetBind_SetBindPoint
    {
        public static void Postfix(SetBind __instance)
        {
            var spellWellstone = GameData.SpellDatabase.GetSpellByID("Expulsion.Wellstone");
            spellWellstone.SpellDesc = $"Bound to {GameData.BindZone}\nTeleports to your last Wishing Well location.";
        }
    }
}