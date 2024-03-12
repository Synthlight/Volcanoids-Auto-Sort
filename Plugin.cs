using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Base_Mod;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine;

namespace Auto_Sort;

[UsedImplicitly]
public class Plugin : BaseGameMod {
    protected override      bool                  UseHarmony => true;
    public static           Dictionary<GUID, int> itemSortOrders;
    public static readonly  List<GUID>            LOGGED_MISSING_ITEMS   = [];
    private static readonly Dictionary<Item, int> BASE_SORT_ORDERS       = CreateSortOrder.Get();
    private const           int                   CURRENT_CONFIG_VERSION = 3;

    protected override void Init() {
        LoadConfig();

        if (itemSortOrders == null) {
            // Init `itemSortOrders` and copy all into it.
            itemSortOrders = [];

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

        base.Init();
    }

    private void LoadConfig() {
        try {
            var configFile = GetConfigFile();

            if (File.Exists(configFile)) {
                var json   = File.ReadAllText(configFile);
                var config = JsonConvert.DeserializeObject<Config>(json);

                if (config.version == CURRENT_CONFIG_VERSION && config.savedSortOrder != null) {
                    itemSortOrders = [];

                    for (var i = 0; i < config.savedSortOrder.Count; i++) {
                        itemSortOrders[config.savedSortOrder[i].guid] = i;
                    }
                }
            }
        } catch (Exception e) {
            Debug.LogError(e.Message);
        }
    }

    private void SaveConfig() {
        var config = new Config {
            version        = CURRENT_CONFIG_VERSION,
            savedSortOrder = new(itemSortOrders.Count)
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
            File.WriteAllText(GetConfigFile(), json);
        } catch (Exception e) {
            Debug.LogError(e.Message);
        }
    }
}