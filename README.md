# Volcanoids Auto-Sort Mod
This is a mod to control/replace the way sorting is done in-game.

- Sort order is changed to follow the order defined in `Auto-Sort.json`. (See [Configuration](#Configuration))
- The online storage tab is auto-sorted by the same rules. (This is a virtual / aggregate view of the inventories you have. This doesn't change or move the actual items, just the display order.)
- Player inventory "Stack" button rearranges items, compressing/restacking and ordering by the sort rules.
- Online storage "Stack" rearranges items, compressing/restacking all the inventories connected to online storage. (Again, ordering by the sort rules.)
  - This also prioritizes storage containers over the drill storage, and fills the drill storage last, if there's not enough room in regular storage.
- Repair Packs are further sorted so the most damage one is listed first. This is because the game uses the first entry in your inventory when repairing.

# Installation
- Extract the release to the Volcanoids mod folder (`%LOCALAPPDATA%Low\Volcanoid\Volcanoids\Mods`) so `Auto-Sort.dll` is placed like this: `%LOCALAPPDATA%Low\Volcanoid\Volcanoids\Mods\Auto-Sort.dll`.

# Configuration
The first time Volcanoids is run with this mod installed, it will create a file called `Auto-Sort.json` in `%LOCALAPPDATA%Low\Volcanoid\Volcanoids\Mods`.<br>
This file is a simple list of the items we resort, **in the order they will sort in-game**.<br>
The list entries contain both the assetId & a name. The name is for reference only. Re-arrange as needed.<br>
Use https://jsonlint.com/ to validate edits made to the file.<br>
If the syntax is wrong, or there's any issue loading the file, it will be ignored and a new default one will be created.

**To customize the sort order, just rearrange the items in the list**.

# Un-installation
- Just remove the dll from `%LOCALAPPDATA%Low\Volcanoid\Volcanoids\Mods`.