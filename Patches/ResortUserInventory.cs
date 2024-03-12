using System.Reflection;
using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;

namespace Auto_Sort.Patches;

/// <summary>Resorts the inventory items when we press the stack button in the char tab.</summary>
[HarmonyPatch]
[UsedImplicitly]
public class ResortUserInventory {
    [HarmonyTargetMethod]
    [UsedImplicitly]
    public static MethodBase TargetMethod() {
        return typeof(InventoryControl).GetMethod(nameof(InventoryControl.Restack), BindingFlags.NonPublic | BindingFlags.Static);
    }

    [HarmonyPostfix]
    [UsedImplicitly]
    public static void Postfix(ref GameObject user, ref InventoryBase inventory) {
        if (inventory is InventorySlotsBase inventorySlotsBase) {
            var resorter = new Resorter();
            resorter.ExtractAllItemsToTemp(inventory, inventorySlotsBase);
            resorter.ResortTempList();
            resorter.PutTempItemsInInventory(inventory);
        }
    }
}