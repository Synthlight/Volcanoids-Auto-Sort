﻿using System.Collections.Generic;

namespace Auto_Sort {
    public static class Extensions {
        public static int TryGet(this Dictionary<string, int> dict, string key) {
            if (dict.ContainsKey(key)) {
                return dict[key];
            } else {
                return -1;
            }
        }
    }
}