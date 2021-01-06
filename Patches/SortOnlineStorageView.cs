using System.Linq;
using System.Reflection;
using BepInEx.Logging;
using HarmonyLib;
using JetBrains.Annotations;

namespace Auto_Sort.Patches {
    /// <summary>Overrides the ICompare for Online Storage, this results in overriding the sorted display.</summary>
    [HarmonyPatch]
    [UsedImplicitly]
    public class SortOnlineStorageView {
        [HarmonyTargetMethod]
        [UsedImplicitly]
        public static MethodBase TargetMethod() {
            return (from interfaceType in typeof(InventoryOnlineSlotPanelUi).GetInterfaces()
                    where interfaceType.Name.Contains("Compare")
                    select typeof(InventoryOnlineSlotPanelUi).GetInterfaceMap(interfaceType)
                                                             .TargetMethods
                                                             .First(info => info.Name.Contains("Compare"))
                ).FirstOrDefault();
        }

        [HarmonyPrefix]
        [UsedImplicitly]
        public static bool Prefix(ref int __result, ref InventoryItem __0, ref InventoryItem __1) {
            if (__0.Item == null || __0.Item.Name == null || __1.Item == null || __1.Item.Name == null) return true;

            var item1Id = __0.Item.AssetId;
            var item2Id = __1.Item.AssetId;

            // Track unknown items we log so we only print it once.
            if (!AutoSortMod.itemSortOrders.ContainsKey(item1Id) && !AutoSortMod.LOGGED_MISSING_ITEMS.Contains(item1Id)) {
                AutoSortMod.Log(LogLevel.Info, $"Found unknown item: \"{item1Id}\"");
                AutoSortMod.LOGGED_MISSING_ITEMS.Add(item1Id);
            }

            __result = AutoSortMod.itemSortOrders.TryGet(item1Id).CompareTo(AutoSortMod.itemSortOrders.TryGet(item2Id));
            return false;
        }
    }
}