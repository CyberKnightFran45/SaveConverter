using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace SaveConverter.PvZ
{
/// <summary> Stores info about Player's Zen Garden </summary>

public class ZenGardenInfo
{
/// <summary> Stinky the Snail Conscious State (Awake or Sleeping) </summary>

public SnailConsciousState SnailState{ get; set; }

/// <summary> Unknown field </summary>

private uint Reserved;

/// <summary> Unknown field </summary>

private uint Reserved2;

/// <summary> List of Plants and their Info </summary>

public List<ZenGardenPlantInfo> ZenPlants{ get; set; }

/// <summary> Creates a new instance of <c>ZenGardenInfo</c> </summary>

public ZenGardenInfo()
{
ZenPlants = new();
}

public static readonly JsonSerializerContext Context = new ZenGardenContext(JsonSerializer.Options);

// Read data from BinaryStream

public static ZenGardenInfo ReadBin(Stream reader)
{

return new()
{
SnailState = (SnailConsciousState)reader.ReadUInt32(),
Reserved = reader.ReadUInt32(),
Reserved2 = reader.ReadUInt32(),
ZenPlants = ZenGardenPlantInfo.ReadEntries(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
writer.WriteUInt32( (uint)SnailState);
writer.WriteUInt32(Reserved);
writer.WriteUInt32(Reserved2);

ZenGardenPlantInfo.WriteEntries(writer, ZenPlants);
}

}

// Context for Serialization

[JsonSerializable(typeof(ZenGardenPlantInfo))]
[JsonSerializable(typeof(List<ZenGardenPlantInfo>))]

public partial class ZenGardenContext : JsonSerializerContext
{
}

}