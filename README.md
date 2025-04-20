# Wellstone
Teleport to your last Wishing Well.

## 🔴Notice❗
- Removing this plugin without removing all occurances of `Expulsion.Wellstone` from your save file will cause your spells/skills to fail to load and may save an empty spell/skill list.
- I recommend adding [SpellSkillCleanupFix](https://github.com/iExpulsion/Expulsion.Erenshor.SpellSkillCleanupFix) to your plugins when using custom spell mods which will handle this for you.

## Features
- Teaches characters a new spell that allows your to teleport to your last Wishing Well.

## Installation
- Requires [BepInEx](https://github.com/BepInEx/BepInEx)
- Download `Expulsion.Erenshor.Wellstone.dll` [Latest Release](https://github.com/iExpulsion/Expulsion.Erenshor.VendorInfo/releases/latest)
- Place the DLL inside your `BepInEx/Plugins` Directory

## Screenshots
![image](https://github.com/user-attachments/assets/899d485d-2134-4997-b10f-c572e2836757)

## Modifications
*Helpful info for determining potential conflicts with other plugins.*
### Postfix Patch
- `SpellDB.Start()`
- `SpellVessel.ResolveSpell()`
- `CharSelectManager.LoadSpellsAndSkills()`
