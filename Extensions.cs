using System.Collections.Generic;

namespace Auto_Sort {
    public static class Extensions {
        public static int TryGet<K>(this Dictionary<K, int> dict, K key) {
            if (dict.ContainsKey(key)) {
                return dict[key];
            }
            return -1;
        }
    }
}