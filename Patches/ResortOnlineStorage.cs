using System;
using System.Reflection;
using BepInEx.Logging;
using HarmonyLib;
using JetBrains.Annotations;

namespace Auto_Sort.Patches {
    /// <summary>Resorts online storage compressing & avoiding the drill inventory if possible.</summary>
    [HarmonyPatch]
    [UsedImplicitly]
    public class ResortOnlineStorage1 {
        [HarmonyTargetMethod]
        [UsedImplicitly]
        public static MethodBase TargetMethod() {
            return typeof(InventoryUiUtils).GetMethod(nameof(InventoryUiUtils.Restack), BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>Directs 'stack' where it needs to go.</summary>
        [HarmonyPrefix]
        [UsedImplicitly]
        public static bool Prefix(ref InventoryUiUtils __instance, ref InventoryUiContext ___m_context) {
            try {
                var tab = __instance.Tab;
                if (tab != null) { // Restack online storage.
                    if (tab is InventoryOnlineSlotPanelUi onlineTab) {
                        var onlineCargo = onlineTab.GetCargo();

                        if (onlineCargo.ValidateUser(___m_context.User)) {
                            var resorter = new Resorter();

                            foreach (var inventory in onlineCargo.Inventories) {
                                if (inventory.TryCast(out IInventorySlots inventorySlots)) {
                                    resorter.ExtractAllItemsToTemp(inventory, inventorySlots);
                                }
                            }

                            resorter.ResortTempList();
                            resorter.PutTempItemsInInventory(onlineCargo);
                        }
                    } else { // Restack single inventory.
                        for (var i = 0; i < tab.InventoryCount; i++) {
                            var inventoryView = tab[i];
                            if (inventoryView.Inventory.TryCast(out IInventorySlots _) && inventoryView.Inventory.ValidateUser(___m_context.User)) {
                                InventoryControl.Restack(inventoryView.Inventory);
                            }
                        }
                    }
                }
            } catch (Exception e) {
                AutoSortMod.Log(LogLevel.Info, $"Error resorting: {e}");
            }

            return false;
        }
    }

    /// <summary>Forces the stack button to always be enabled.</summary>
    [HarmonyPatch]
    [UsedImplicitly]
    public class ResortOnlineStorage2 {
        [HarmonyTargetMethod]
        [UsedImplicitly]
        public static MethodBase TargetMethod() {
            return typeof(InventoryUiUtils).GetMethod("GetInfo", BindingFlags.NonPublic | BindingFlags.Instance);
        }

        [HarmonyPostfix]
        [UsedImplicitly]
        public static void Postfix(ref bool canRestack) {
            canRestack = true;
        }
    }
}