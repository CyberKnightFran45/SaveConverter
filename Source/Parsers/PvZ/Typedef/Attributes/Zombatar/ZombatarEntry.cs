using System.Collections.Generic;
using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Info for a Zombatar Picture </summary>

public class ZombatarEntry
{
/// <summary> Unknown field </summary>

private int Reserved = -1;

/// <summary> Skin Color </summary>

public uint SkinColor{ get; set; }

/// <summary> Clothes Type </summary>

public int ClothesType{ get; set; }

/// <summary> Clothes Color </summary>

public uint ClothesColor{ get; set; }

/// <summary> Tidbits Color </summary>

public int TidbitsType{ get; set; }

/// <summary> Tidbits Color </summary>
  
public uint TidbitsColor{ get; set; }

/// <summary> Accessories Type </summary>
  
public int AccessoriesType{ get; set; }

/// <summary> Accessories Color </summary>

public uint AccessoriesColor{ get; set; }

/// <summary> Facial hair Type </summary>
  
public int FacialHairType{ get; set; }

/// <summary> Facial hair Color </summary>

public uint FacialHairColor{ get; set; }

/// <summary> Hair Type </summary>
  
public int HairType{ get; set; }

/// <summary> Hair Color </summary>

public uint HairColor{ get; set; }

/// <summary> Eyewear Type </summary>

public int EyewearType{ get; set; }

/// <summary> Eyewear Color </summary>
 
public uint EyewearColor{ get; set; }

/// <summary> Hat Type </summary>

public int HatType{ get; set; }

/// <summary> Hat Color </summary>

public uint HatColor{ get; set; }

/// <summary> Backdrop Type </summary>
  
public uint BackdropType{ get; set; }

/// <summary> Backdrop Color </summary>

public uint BackdropColor{ get; set; }

/// <summary> Creates a new <c>ZombatarEntry</c> </summary>

public ZombatarEntry()
{
}

// Read data from BinaryStream

private static ZombatarEntry Read(Stream reader)
{

return new()
{
Reserved = reader.ReadInt32(),

SkinColor = reader.ReadUInt32(),

ClothesType = reader.ReadInt32(),
ClothesColor = reader.ReadUInt32(),

TidbitsType = reader.ReadInt32(),
TidbitsColor = reader.ReadUInt32(),

AccessoriesType = reader.ReadInt32(),
AccessoriesColor = reader.ReadUInt32(),

FacialHairType = reader.ReadInt32(),
FacialHairColor = reader.ReadUInt32(),

HairType = reader.ReadInt32(),
HairColor = reader.ReadUInt32(),

EyewearType = reader.ReadInt32(),
EyewearColor = reader.ReadUInt32(),

HatType = reader.ReadInt32(),
HatColor = reader.ReadUInt32(),

BackdropType = reader.ReadUInt32(),
BackdropColor = reader.ReadUInt32()
};

}

// Read All Entries

public static List<ZombatarEntry> ReadAll(Stream reader)
{
int count = reader.ReadInt32();

if(count < 0)
return null;

List<ZombatarEntry> entries = new(count);

for(uint i = 0; i < count; i++)
entries.Add(Read(reader) );	

return entries;
}

// Write data to BinaryStream

private void Write(Stream writer)
{
writer.WriteInt32(Reserved);

writer.WriteUInt32(SkinColor);

writer.WriteInt32(ClothesType);
writer.WriteUInt32(ClothesColor);

writer.WriteInt32(TidbitsType);
writer.WriteUInt32(TidbitsColor);

writer.WriteInt32(AccessoriesType);
writer.WriteUInt32(AccessoriesColor);

writer.WriteInt32(FacialHairType);
writer.WriteUInt32(FacialHairColor);

writer.WriteInt32(HairType);
writer.WriteUInt32(HairColor);

writer.WriteInt32(EyewearType);
writer.WriteUInt32(EyewearColor);

writer.WriteInt32(HatType);
writer.WriteUInt32(HatColor);

writer.WriteUInt32(BackdropType);
writer.WriteUInt32(BackdropColor);
}

// Save All Entries

public static void WriteAll(Stream writer, List<ZombatarEntry> entries)
{
int count = entries is null ? -1 : entries.Count;
writer.WriteInt32(count);

for(int i = 0; i < count; i++)
entries[i].Write(writer);	

}

}

}