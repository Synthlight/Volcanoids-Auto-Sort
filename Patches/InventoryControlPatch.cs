using System.Collections.Generic;
using System.Reflection;
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

                //itemsToSort.Sort((item1, item2) => item1.itemDefinition.Category.SortOrder.CompareTo(item2.itemDefinition.Category.SortOrder));
                itemsToSort.Sort((item1, item2) => {
                    var item1Name = item1.itemDefinition.Name;
                    var item2Name = item2.itemDefinition.Name;

                    return item1Name == item2Name ? 0 : AutoSortMod.itemSortOrders.TryGet(item1Name).CompareTo(AutoSortMod.itemSortOrders.TryGet(item2Name));
                });

                foreach (var item in itemsToSort) {
                    //GMod.Log(LogLevel.Info, $"Adding {item.amount} \"{item.itemDefinition.Name}\".");
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