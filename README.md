# Volcanoids Auto-Sort Mod
This is a mod to control/replace the way sorting is done in-game.
This changes two primary things:
- Sorting in a character (or offline) tab rearranges the contents by the sort rules.
- The Online inventory tab is auto-sorted by the same rules.

The first Volcanoids is run with this mod installed, it will create a file called `sort-order.json` in `Volcanoids\BepInEx\config`.
This file is a simple list of the game items we resort, **in the order they will sort in-game**.

**To customize the sort order, just rearrange the items in the list**.

# Requirements
- Volcanoids obviously.
- BepInEx: https://github.com/BepInEx/BepInEx (You want the x64 version.)

# Installation
- Extract BepInEx to the root Volcanoids folder so `winhttp.dll` is in the same folder as `Volcanoids.exe`.
- Extract this mod so `Auto-Sort.dll` is placed like this: `Volcanoids\BepInEx\plugins\Auto-Sort.dll`.

# Un-installation
BepInEx uses `winhttp.dll` as an injector/loader. Renaming or deleting this file is enough to disable both my mod and the loader.