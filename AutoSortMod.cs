using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine;

namespace Auto_Sort {
    [UsedImplicitly]
    public class AutoSortMod : GameMod {
        public static           Dictionary<GUID, int> itemSortOrders;
        public static readonly  List<GUID>            LOGGED_MISSING_ITEMS = new List<GUID>();
        private static readonly Dictionary<Item, int> BASE_SORT_ORDERS     = CreateSortOrder.Get();
        private static readonly string                CONFIG_FILE          = Path.Combine(AssemblyDirectory, "Auto-Sort.json");

        public override void Load() {
            Debug.Log("Auto-Sort loaded.");

            Init();

            var harmony = new Harmony(GUID.Create().ToString());
            harmony.PatchAll();

            foreach (var patchedMethod in harmony.GetPatchedMethods()) {
                Debug.Log($"Patched: {patchedMethod.DeclaringType?.FullName}:{patchedMethod}");
            }
        }

        public override void Unload() {
        }

        private static void Init() {
            LoadConfig();

            if (itemSortOrders == null) {
                // Init `itemSortOrders` and copy all into it.
                itemSortOrders = new Dictionary<GUID, int>();

                foreach (var key in BASE_SORT_ORDERS.Keys) {
                    itemSortOrders[key.guid] = BASE_SORT_ORDERS[key];
                }
            } else {
                // `itemSortOrders` was loaded from a config. Add missing items into it.
                var i = itemSortOrders.Count;

                foreach (var key in BASE_SORT_ORDERS.Keys.Where(key => !itemSortOrders.ContainsKey(key.guid))) {
                    itemSortOrders[key.guid] = i++;
                }
            }

            SaveConfig();
        }

        private static void LoadConfig() {
            try {
                if (File.Exists(CONFIG_FILE)) {
                    var json   = File.ReadAllText(CONFIG_FILE);
                    var config = JsonConvert.DeserializeObject<Config>(json);

                    if (config.savedSortOrder != null) {
                        itemSortOrders = new Dictionary<GUID, int>();

                        for (var i = 0; i < config.savedSortOrder.Count; i++) {
                            itemSortOrders[config.savedSortOrder[i].guid] = i;
                        }
                    }
                }
            } catch (Exception e) {
                Debug.LogError(e.Message);
            }
        }

        private static void SaveConfig() {
            var config = new Config {
                version        = 1,
                savedSortOrder = new List<Item>(itemSortOrders.Count)
            };

            // Convert `itemSortOrders` (Dictionary<GUID, int>) into (List<Item>) to save.
            foreach (var item in from guid in itemSortOrders.Keys
                                 from item in BASE_SORT_ORDERS.Keys
                                 where item.AssetId == guid.ToString()
                                 select item) {
                config.savedSortOrder.Add(item);
            }

            try {
                var json = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText(CONFIG_FILE, json);
            } catch (Exception e) {
                Debug.LogError(e.Message);
            }
        }

        private static string AssemblyDirectory {
            get {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri      = new UriBuilder(codeBase);
                var path     = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
    }
}