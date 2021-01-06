using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Auto_Sort {
    [BepInPlugin(UUID, "Auto-Sort Mod", "1.0.0.0")]
    [UsedImplicitly]
    public class AutoSortMod : BaseUnityPlugin {
        private const  string          UUID = "com.auto-sort";
        private static ManualLogSource logSource;

        public static          Dictionary<GUID, int> itemSortOrders;
        public static readonly List<GUID>            LOGGED_MISSING_ITEMS = new List<GUID>();

        [UsedImplicitly]
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
                if (File.Exists(sortFile)) {
                    var json   = File.ReadAllText(sortFile);
                    var config = JsonConvert.DeserializeObject<Config>(json);

                    if (config.savedSortOrder != null) {
                        itemSortOrders = new Dictionary<GUID, int>();

                        for (var i = 0; i < config.savedSortOrder.Count; i++) {
                            itemSortOrders[config.savedSortOrder[i].AssetId] = i;
                        }
                    }
                }
            } catch (Exception e) {
                Log(LogLevel.Error, e.Message);
            } finally {
                var sortOrders = CreateSortOrder.Get();

                if (itemSortOrders == null) {
                    itemSortOrders = new Dictionary<GUID, int>();
                    foreach (var key in sortOrders.Keys) {
                        itemSortOrders[key.AssetId] = sortOrders[key];
                    }
                } else {
                    var i = itemSortOrders.Count;

                    // Add new GUIDs not in the loaded config.
                    foreach (var key in sortOrders.Keys.Where(key => !itemSortOrders.ContainsKey(key.AssetId))) {
                        itemSortOrders[key.AssetId] = i++;
                    }
                }

                try {
                    var config = new Config {
                        version        = 1,
                        savedSortOrder = new List<Item>(itemSortOrders.Count)
                    };

                    foreach (var item in from guid in itemSortOrders.Keys
                                         from item in sortOrders.Keys
                                         where item.AssetId == guid
                                         select item) {
                        config.savedSortOrder.Add(item);
                    }

                    var json = JsonConvert.SerializeObject(config, Formatting.Indented);
                    File.WriteAllText(sortFile, json);
                } catch (Exception e) {
                    Log(LogLevel.Error, e.Message);
                }
            }
        }

        public static void Log(LogLevel level, string msg) {
            logSource.Log(level, msg);
        }
    }
}