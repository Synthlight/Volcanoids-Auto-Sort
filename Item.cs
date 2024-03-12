using Newtonsoft.Json;

namespace Auto_Sort;

public class Item(string assetId, string name) {
    public string AssetId { get; } = assetId;

    [JsonIgnore]
    public GUID guid => GUID.Parse(AssetId);

    /** For reference only. **/
    public string Name { get; } = name;

    protected bool Equals(Item other) {
        return AssetId.Equals(other.AssetId);
    }

#pragma warning disable IDE0041 // Use 'is null' check
    public override bool Equals(object obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if (obj.GetType() != GetType()) return false;
        return Equals((Item) obj);
    }
#pragma warning restore IDE0041 // Use 'is null' check

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