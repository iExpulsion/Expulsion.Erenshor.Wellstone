using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace Expulsion.Erenshor.Wellstone
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        internal static ManualLogSource? Log;

        private const string PluginGuid = "Expulsion.Erenshor.Wellstone";
        private const string PluginName = "Wellstone";
        private const string PluginVersion = "1.0.0";

        private Harmony? _harmonyInstance;

        private void Awake()
        {
            Log = Logger;

            _harmonyInstance = new Harmony(PluginGuid);
            _harmonyInstance.PatchAll();

            Log.LogInfo($"Plugin {PluginName} is loaded!");
        }

        private void OnDestroy()
        {
            _harmonyInstance?.UnpatchSelf();
        }
    }
}