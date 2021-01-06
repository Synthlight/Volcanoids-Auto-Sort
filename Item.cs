using Newtonsoft.Json;

namespace Auto_Sort {
    public class Item {
        public string AssetId { get; }

        [JsonIgnore]
        public GUID guid => GUID.Parse(AssetId);

        /** For reference only. **/
        public string Name { get; }

        public Item(string assetId, string name) {
            AssetId = assetId;
            Name    = name;
        }

        protected bool Equals(Item other) {
            return AssetId.Equals(other.AssetId);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Item) obj);
        }

        public override int GetHashCode() {
            return AssetId.GetHashCode();
        }

        public static bool operator ==(Item left, Item right) {
            return Equals(left, right);
        }

        public static bool operator !=(Item left, Item right) {
            return !Equals(left, right);
        }
    }
}