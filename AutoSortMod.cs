using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Auto_Sort {
    [BepInPlugin(UUID, "Auto-Sort Mod", "1.0.0.0")]
    [UsedImplicitly]
    public class AutoSortMod : BaseUnityPlugin {
        private const string UUID = "com.auto-sort";
        private static ManualLogSource logSource;

        public static Dictionary<string, int> itemSortOrders;

        public void Awake() {
            logSource = Logger;

            Log(LogLevel.Info, "Auto-Sort loaded.");

            Init();

            var harmony = new Harmony(UUID);
            harmony.PatchAll();

            foreach (var patchedMethod in harmony.GetPatchedMethods()) {
                Log(LogLevel.Info, $"Patched: {patchedMethod.DeclaringType?.FullName}:{patchedMethod}");
            }
        }

        private void Init() {
            var sortFile = Path.Combine(Paths.ConfigPath, "sort-order.json");

            try {
                string json = null;

                if (File.Exists(sortFile)) {
                    json = File.ReadAllText(sortFile);
                }

                if (json != null) {
                    var list = JsonConvert.DeserializeObject<List<string>>(json);
                    itemSortOrders = new Dictionary<string, int>();
                    for (var i = 0; i < list.Count; i++) {
                        itemSortOrders[list[i]] = i;
                    }
                }
            } catch (Exception e) {
                Log(LogLevel.Error, e.Message);
            } finally {
                if (itemSortOrders == null) {
                    itemSortOrders = CreateSortOrder.Get();

                    try {
                        var json = JsonConvert.SerializeObject(itemSortOrders.Keys, Formatting.Indented);
                        File.WriteAllText(sortFile, json);
                    } catch (Exception e) {
                        Log(LogLevel.Error, e.Message);
                    }
                }
            }
        }

        public static void Log(LogLevel level, string msg) {
            logSource.Log(level, msg);
        }
    }
}