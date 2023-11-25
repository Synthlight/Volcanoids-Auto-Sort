using System;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;

namespace Auto_Sort.Patches {
    /// <summary>Resorts online storage compressing & avoiding the drill inventory if possible.</summary>
    [HarmonyPatch]
    [UsedImplicitly]
    public class ResortOnlineStorage1 {
        [HarmonyTargetMethod]
        [UsedImplicitly]
        public static MethodBase TargetMethod() {
            return typeof(InventoryControlUi).GetMethod(nameof(InventoryControlUi.Restack), BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>Directs 'stack' where it needs to go.</summary>
        [HarmonyPrefix]
        [UsedImplicitly]
        public static bool Prefix(ref InventoryControlUi __instance) {
            try {
                var tab = __instance.Tab;
                if (tab != null) { // Restack online storage.
                    if (tab is InventoryOnlineSlotPanelUi onlineTab) {
                        var onlineCargo = onlineTab.m_cargo;
                        var resorter    = new Resorter();

                        foreach (var inventory in onlineCargo.Inventories) {
                            resorter.ExtractAllItemsToTemp(inventory, inventory);
                        }

                        resorter.ResortTempList();
                        resorter.PutTempItemsInInventory(onlineCargo);
                    } else { // Restack single inventory.
                        InventoryUiUtils.Restack(__instance.Tab, __instance.m_context.User);
                    }
                }
            } catch (Exception e) {
                Debug.LogError($"Error resorting: {e}");
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
            return typeof(InventoryControlUi).GetMethod(nameof(InventoryControlUi.GetInfo), BindingFlags.Public | BindingFlags.Static);
        }

        [HarmonyPostfix]
        [UsedImplicitly]
        public static void Postfix(ref bool canRestack) {
            canRestack = true;
        }
    }

    /// <summary>Custom inventory compare to make the drill the last entry.</summary>
    [HarmonyPatch]
    [UsedImplicitly]
    public class ResortOnlineStorage3 {
        [HarmonyTargetMethod]
        [UsedImplicitly]
        public static MethodBase TargetMethod() {
            return (from interfaceType in typeof(OnlineCargo).GetInterfaces()
                    where interfaceType.Name.Contains("Compare")
                    select typeof(OnlineCargo).GetInterfaceMap(interfaceType)
                                              .TargetMethods
                                              .First(info => info.Name.Contains("Compare"))
                ).FirstOrDefault();
        }

        [HarmonyPrefix]
        [UsedImplicitly]
        public static bool Prefix(ref int __result, ref Inventory __0, ref Inventory __1, ref GameObject ___m_currentSource) {
            if (__0?.name?.Contains("SegmentFront") == true) {
                __result = 1;
                return false;
            }
            if (__1?.name?.Contains("SegmentFront") == true) {
                __result = -1;
                return false;
            }

            var num   = Vector3.SqrMagnitude(___m_currentSource.transform.position - __0.transform.position);
            var value = Vector3.SqrMagnitude(___m_currentSource.transform.position - __1.transform.position);
            __result = num.CompareTo(value);

            return false;
        }
    }
}