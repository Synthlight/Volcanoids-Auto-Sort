using System;
using System.Collections.Generic;
using UnityEngine;

namespace Auto_Sort {
    public class Resorter {
        private static readonly GUID REPAIR_KIT = GUID.Parse("1bf6d40a49d9e2148a2d2389a768f15f");

        private readonly List<ItemTemp> itemsToSort = new List<ItemTemp>();

        public void ExtractAllItemsToTemp(InventoryBase inventory, InventorySlotsBase inventorySlots) {
            for (var i = 0; i < inventorySlots.Capacity; i++) {
                if (inventorySlots.TryGetSlot(i, out var inventoryItem)) {
                    var itemTemp = new ItemTemp();
                    itemTemp.propertySet.SetStats(inventoryItem.Stats);
                    itemTemp.amount         = inventory.Remove(null, inventoryItem.Item, inventoryItem.Stats, inventoryItem.Amount, i);
                    itemTemp.itemDefinition = inventoryItem.Item;

                    itemsToSort.Add(itemTemp);
                }
            }
        }

        public void ResortTempList() {
            itemsToSort.Sort((item1, item2) => {
                var item1Id = item1.itemDefinition.AssetId;
                var item2Id = item2.itemDefinition.AssetId;

                if (item1Id == item2Id && item1Id == REPAIR_KIT) {
                    try {
                        var healthStat = RuntimeAssetCache<CommonStats>.Instance.Health;
                        var health1    = item1.propertySet.TryGet(healthStat, out PropertyValue health1Prop) ? health1Prop.GetValueOrDefault(PropertyType.Float, 1f) : 1f;
                        var health2    = item2.propertySet.TryGet(healthStat, out PropertyValue health2Prop) ? health2Prop.GetValueOrDefault(PropertyType.Float, 1f) : 1f;

                        return health1.CompareTo(health2);
                    } catch (Exception e) {
                        Debug.LogError("Error sorting by durability:\n" + e);
                    }
                }

                return item1Id == item2Id ? 0 : Plugin.itemSortOrders.TryGet(item1Id).CompareTo(Plugin.itemSortOrders.TryGet(item2Id));
            });
        }

        public void PutTempItemsInInventory(InventoryBase inventory) {
            foreach (var item in itemsToSort) {
                inventory.Add(null, item.itemDefinition, item.propertySet, item.amount, 0);
                item.propertySet.Clear();
            }
            itemsToSort.Clear();
        }

        private class ItemTemp {
            public          ItemDefinition itemDefinition;
            public readonly PropertySet    propertySet = new PropertySet(1);
            public          int            amount;
        }
    }
}