using HarmonyLib;

namespace Expulsion.Erenshor.Wellstone.Patches
{
    [HarmonyPatch(typeof(CharSelectManager), "LoadSpellsAndSkills")]
    public class CharSelectManager_LoadSpellsAndSkills
    {
        public static void Postfix(CharSelectManager __instance)
        {
            var spellWellstone = GameData.SpellDatabase.GetSpellByID("Expulsion.Wellstone");
            spellWellstone.SpellDesc = $"Binded to {GameData.BindZone}\nTeleports to your last Wishing Well location.";

            if (!GameData.CurrentCharacterSlot.CharacterSpells.Contains(spellWellstone.Id))
            {
                Plugin.Log?.LogInfo("Adding Wellstone to SpellBook");
                GameData.GM.PlayerSpells.KnownSpells.Add(spellWellstone);
            }
            else
            {
                Plugin.Log?.LogInfo("Wellstone already in SpellBook");
            }
        }
    }
}