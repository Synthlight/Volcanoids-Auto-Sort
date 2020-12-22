using System;
using System.Collections.Generic;
using System.Reflection;
using BepInEx.Logging;
using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;

namespace Auto_Sort.Patches {
    [HarmonyPatch]
    [UsedImplicitly]
    public class InventoryControlPatch {
        [HarmonyTargetMethod]
        [UsedImplicitly]
        public static MethodBase TargetMethod() {
            return typeof(InventoryControl).GetMethod(nameof(InventoryControl.Restack), BindingFlags.NonPublic | BindingFlags.Static);
        }

        /// <summary>Resorts the inventory items when we press the stack button in the char tab.</summary>
        [HarmonyPostfix]
        [UsedImplicitly]
        public static void Postfix(ref GameObject user, ref InventoryBase inventory) {
            if (inventory.TryCast(out IInventorySlots inventorySlots)) {
                var itemsToSort = new List<ItemTemp>();

                for (var i = 0; i < inventorySlots.Capacity; i++) {
                    if (inventorySlots.TryGetSlot(i, out var inventoryItem)) {
                        var itemTemp = new ItemTemp();
                        inventoryItem.Stats.CopyTo(itemTemp.propertySet);
                        itemTemp.amount         = inventory.Remove(null, inventoryItem.Item, inventoryItem.Stats, inventoryItem.Amount, i);
                        itemTemp.itemDefinition = inventoryItem.Item;

                        itemsToSort.Add(itemTemp);
                    }
                }

                itemsToSort.Sort((item1, item2) => {
                    var item1Name = item1.itemDefinition.Name.Trim() + "::" + item1.itemDefinition.AssetId;
                    var item2Name = item2.itemDefinition.Name.Trim() + "::" + item2.itemDefinition.AssetId;

                    if (item1Name == item2Name && item1Name == "Module repair kit::1bf6d40a49d9e2148a2d2389a768f15f") {
                        try {
                            var healthStat = RuntimeAssetCache<CommonStats>.Instance.Health;
                            var health1    = item1.propertySet.TryGet(healthStat, out PropertyValue health1Prop) ? health1Prop.GetValueOrDefault(PropertyType.Float, 1f) : 1f;
                            var health2    = item2.propertySet.TryGet(healthStat, out PropertyValue health2Prop) ? health2Prop.GetValueOrDefault(PropertyType.Float, 1f) : 1f;

                            return health1.CompareTo(health2);
                        } catch (Exception e) {
                            AutoSortMod.Log(LogLevel.Error, "Error sorting by durability:\n" + e);
                        }
                    }

                    return item1Name == item2Name ? 0 : AutoSortMod.itemSortOrders.TryGet(item1Name).CompareTo(AutoSortMod.itemSortOrders.TryGet(item2Name));
                });

                foreach (var item in itemsToSort) {
                    inventory.Add(null, item.itemDefinition, item.propertySet, item.amount, 0);
                    item.propertySet.Clear();
                }
            }
        }

        private class ItemTemp {
            public          ItemDefinition itemDefinition;
            public readonly PropertySet    propertySet = new PropertySet(1);
            public          int            amount;
        }
    }
}