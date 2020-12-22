# Volcanoids Auto-Sort Mod
This is a mod to control/replace the way sorting is done in-game.

- Sort order is changed to follow the order defined in `sort-order.json`. (See [Configuration](#Configuration))
- The online storage tab is auto-sorted by the same rules. (This is a virtual / aggregate view of the inventories you have. This doesn't change or move the actual items, just the display order.)
- Player inventory "Stack" button rearranges items, compressing/restacking and ordering by the sort rules.
- Online storage "Stack" rearranges items, compressing/restacking all the inventories connected to online storage. (Again, ordering by the sort rules.)
  - This also prioritizes storage containers over the drill storage, and fills the drill storage last, if there's not enough room in regular storage.
- Repair Packs are further sorted so the most damage one is listed first. This is because the game uses the first entry in your inventory when repairing.

# Requirements
- Volcanoids obviously.
- BepInEx: https://github.com/BepInEx/BepInEx (You want the x64 version.)

# Installation
- Extract BepInEx to the root Volcanoids folder so `winhttp.dll` is in the same folder as `Volcanoids.exe`.
- Extract this mod so `Auto-Sort.dll` is placed like this: `Volcanoids\BepInEx\plugins\Auto-Sort.dll`.

# Configuration
The first time Volcanoids is run with this mod installed, it will create a file called `sort-order.json` in `Volcanoids\BepInEx\config`.<br>
This file is a simple list of the items we resort, **in the order they will sort in-game**.

**To customize the sort order, just rearrange the items in the list**.

# Un-installation
BepInEx uses `winhttp.dll` as an injector/loader. Renaming or deleting this file is enough to disable both my mod and the loader.