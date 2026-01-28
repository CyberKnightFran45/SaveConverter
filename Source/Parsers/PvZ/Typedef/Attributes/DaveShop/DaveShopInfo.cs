using System.IO;
using System.Text.Json.Serialization;

namespace SaveConverter.PvZ
{
/// <summary> Records which Items were Bough in Dave's Shop </summary>

public class DaveShopInfo
{
/// <summary> Plant Record </summary>

public PlantStoreRecord PlantRecord{ get; set; }

/// <summary> Unknown field </summary>

private uint Reserved;

/// <summary> Items from Zen Garden </summary>

public ZenItemsRecord ZenItems{ get; set; }

/// <summary> Number of Extra SeedSlots </summary>

public uint ExtraSeedSlots{ get; set; }

/// <summary> Has <c>Pool Cleaner</c></summary>

public bool PoolCleaner{ get; set; }

/// <summary> Has <c>Roof Cleaner</c> </summary>

public bool RoofCleaner{ get; set; }

/// <summary> Number of Rake uses </summary>

public uint RakeUses{ get; set; }

/// <summary> Has <c>Aquarium Garden</c> </summary>

public bool AquariumGarden{ get; set; }

/// <summary> Amount of Chocolate </summary>

public int? Chocolate{ get; set; }

/// <summary> Has <c>Tree of Wisdom</c> </summary>

public bool TreeOfWisdom{ get; set; }

/// <summary> Amount of Tree Food </summary>

public int? TreeFood{ get; set; }

/// <summary> Has Upgrade: <c>Wall-nut First Aid</c> </summary>

public bool WallNutAid{ get; set; }

/// <summary> Creates a new instance of <c>DaveShopInfo</c> </summary>

public DaveShopInfo()
{
PlantRecord = new();
ZenItems = new();
}

public static readonly JsonSerializerContext Context = new DaveShopContext(JsonSerializer.Options);

// Read data from BinaryStream

public static DaveShopInfo ReadBin(Stream reader)
{

return new()
{
PlantRecord = PlantStoreRecord.ReadBin(reader),
Reserved = reader.ReadUInt32(),
ZenItems = ZenItemsRecord.ReadBin(reader),
ExtraSeedSlots = reader.ReadUInt32(),
PoolCleaner = Boolean32.Read(reader),
RoofCleaner = Boolean32.Read(reader),
RakeUses = reader.ReadUInt32(),
AquariumGarden = Boolean32.Read(reader),
Chocolate = Offset32.Read(reader, 1000),
TreeOfWisdom = Boolean32.Read(reader),
TreeFood = Offset32.Read(reader, 1000),
WallNutAid = Boolean32.Read(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
PlantRecord.WriteBin(writer);
writer.WriteUInt32(Reserved);

ZenItems.WriteBin(writer);
writer.WriteUInt32(ExtraSeedSlots);

Boolean32.Write(writer, PoolCleaner);
Boolean32.Write(writer, RoofCleaner);

writer.WriteUInt32(RakeUses);
Boolean32.Write(writer, AquariumGarden);

Offset32.Write(writer, Chocolate, 1000);
Boolean32.Write(writer, TreeOfWisdom);

Offset32.Write(writer, TreeFood, 1000);
Boolean32.Write(writer, WallNutAid);
}

}

// Context for Serialization

[JsonSerializable(typeof(PlantStoreRecord))]
[JsonSerializable(typeof(ZenItemsRecord))]

public partial class DaveShopContext : JsonSerializerContext
{
}

}