using System.Collections.Generic;

namespace Auto_Sort;

public static class Extensions {
    public static int TryGet<K>(this Dictionary<K, int> dict, K key) {
        return System.Collections.Generic.CollectionExtensions.GetValueOrDefault(dict, key, -1);
    }
}