using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace SaveConverter.PvZ
{
/// <summary> Info for a Zen Garden Plant </summary>

public class ZenGardenPlantInfo
{
/// <summary> Plant Type </summary>

public PlantTypeID PlantType{ get; set; }

/// <summary> Garden Location </summary>

public GardenLocationID GardenLocation{ get; set; }

/// <summary> Position of Plant </summary>

public SexyPoint PlantPos{ get; set; }

/// <summary> Plant face direction </summary>

public PlantFaceDirectionID FaceDirection{ get; set; }

/// <summary> Unknown field </summary>

private uint Reserved;

/// <summary> Last time plant was watered </summary>

public DateTime LastTimeWatered{ get; set; }

/// <summary> Unknown field </summary>

private uint Reserved2;

/// <summary> Plant Color </summary>

public PlantColorID PlantColor{ get; set; }

/// <summary> Number of Times fertilized </summary>

public uint TimesFertilized{ get; set; }

/// <summary> Number of Times watered </summary>

public uint TimesWatered{ get; set; }

/// <summary> Number of times plant needs to be watered </summary>

public uint WateringNeedTimes{ get; set; }

/// <summary> Plant Needs </summary>

public ZenGardenPlantNeeds PlantNeeds{ get; set; }

/// <summary> Unknown field </summary>

private uint Reserved3;

/// <summary> Last time Phonograph/Bug Spray was used (Plant is Happy) </summary>

public DateTime LastHappyTime{ get; set; }

/// <summary> Unknown field </summary>

private uint Reserved4;

/// <summary> Last time fertilized </summary>

public DateTime LastTimeFertilized{ get; set; }

/// <summary> Unknown field </summary>

private uint Reserved5;

/// <summary> Last time plant was fed with Chocolate </summary>

public DateTime LastChocolateTime{ get; set; }

/// <summary> Unknown field </summary>

private uint Reserved6;

/// <summary> Unknown field </summary>

private uint Reserved7;

/// <summary> Unknown field </summary>

private uint Reserved8;

/// <summary> Creates a new instance of <c>ZenGardenPlantInfo</c> </summary>

public ZenGardenPlantInfo()
{
}

public static readonly JsonSerializerContext Context = new ZenGardenPlantContext(JsonSerializer.Options);

// Read data from BinaryStream

private static ZenGardenPlantInfo Read(Stream reader)
{

return new()
{
PlantType = (PlantTypeID)reader.ReadUInt32(),
GardenLocation = (GardenLocationID)reader.ReadUInt32(),
PlantPos = SexyPoint.Read(reader),
FaceDirection = (PlantFaceDirectionID)reader.ReadUInt32(),
Reserved = reader.ReadUInt32(),
LastTimeWatered = UnixHelper.Read(reader),
Reserved2 = reader.ReadUInt32(),
PlantColor = (PlantColorID)reader.ReadUInt32(),
TimesFertilized = reader.ReadUInt32(),
TimesWatered = reader.ReadUInt32(),
WateringNeedTimes = reader.ReadUInt32(),
PlantNeeds = (ZenGardenPlantNeeds)reader.ReadUInt32(),
Reserved3 = reader.ReadUInt32(),
LastHappyTime = UnixHelper.Read(reader),
Reserved4 = reader.ReadUInt32(),
LastTimeFertilized = UnixHelper.Read(reader),
Reserved5 = reader.ReadUInt32(),
LastChocolateTime = UnixHelper.Read(reader),
Reserved6 = reader.ReadUInt32(),
Reserved7 = reader.ReadUInt32(),
Reserved8 = reader.ReadUInt32()
};

}

// Read Entries

public static List<ZenGardenPlantInfo> ReadEntries(Stream reader)
{
int count = reader.ReadInt32();

if(count < 0)
return null;

List<ZenGardenPlantInfo> zenPlants = new(count);

for(int i = 0; i < count; i++)
zenPlants.Add(Read(reader) );	

return zenPlants;
}

// Write data to BinaryStream

private void Write(Stream writer)
{
writer.WriteUInt32( (uint)PlantType);
writer.WriteUInt32(( uint)GardenLocation);

PlantPos.Write(writer);

writer.WriteUInt32( (uint)FaceDirection);

writer.WriteUInt32(Reserved);
UnixHelper.Write(writer, LastTimeWatered);

writer.WriteUInt32(Reserved2);

writer.WriteUInt32( (uint)PlantColor);
writer.WriteUInt32(TimesFertilized);
writer.WriteUInt32(TimesWatered);
writer.WriteUInt32(WateringNeedTimes);
writer.WriteUInt32( (uint)PlantNeeds);

writer.WriteUInt32(Reserved3);
UnixHelper.Write(writer, LastHappyTime);

writer.WriteUInt32(Reserved4);
UnixHelper.Write(writer, LastTimeFertilized);

writer.WriteUInt32(Reserved5);
UnixHelper.Write(writer, LastChocolateTime);
	
writer.WriteUInt32(Reserved6);
writer.WriteUInt32(Reserved7);
writer.WriteUInt32(Reserved8);
}

// Save ZenPlants

public static void WriteEntries(Stream writer, List<ZenGardenPlantInfo> zenPlants)
{
int count = zenPlants is null ? -1 : zenPlants.Count;
writer.WriteInt32(count);

for(int i = 0; i < count; i++)
zenPlants[i].Write(writer);	

}

}

// Context for Serialization

[JsonSerializable(typeof(DateTime))]
[JsonSerializable(typeof(SexyPoint))]

public partial class ZenGardenPlantContext : JsonSerializerContext
{
}

}