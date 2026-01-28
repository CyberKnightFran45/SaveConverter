using System;
using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Records which Achievements were Unlocked </summary>

public class AchievementsInfo
{
/// <summary> <c>Home Lawn Security</c> State </summary>

public bool HomeSecurity{ get; set; }

/// <summary> <c>Nobel Peas Prize</c> State </summary>

public bool NobelPeas{ get; set; }

/// <summary> <c>Better Off Dead</c> State </summary>

public bool Better_Off_Dead{ get; set; }

/// <summary> <c>China Shop</c> State </summary>

public bool ChinaShop{ get; set; }

/// <summary> <c>SPUDOW!</c> State </summary>

public bool Spudow{ get; set; }

/// <summary> <c>Explodonator</c> State </summary>

public bool Explodonator{ get; set; }

/// <summary> <c>Morticulturalist/c> State </summary>

public bool Morticulturalist{ get; set; }

/// <summary> <c>Don't Pea in the Pool</c> State </summary>

public bool DontPInPool{ get; set; }

/// <summary> <c>Roll Some Heads</c> State </summary>

public bool Roll_Some_Heads{ get; set; }

/// <summary> <c>Grounded</c> State </summary>

public bool Grounded{ get; set; }

/// <summary> <c>Zombologist</c> State </summary>

public bool Zombologist{ get; set; }

/// <summary> <c>Penny Pincher</c> State </summary>

public bool PennyPincher{ get; set; }

/// <summary> <c>Sunny Days</c> State </summary>

public bool SunnyDays{ get; set; }

/// <summary> <c>Popcorn Party</c> State </summary>

public bool PopcornParty{ get; set; }

/// <summary> <c>Good Morning</c> State </summary>

public bool GoodMorning{ get; set; }

/// <summary> <c>No Fungus Among Us</c> State </summary>

public bool No_Fungus_Among_Us{ get; set; }

/// <summary> <c>Beyond the Grave</c> State </summary>

public bool BeyondGrave{ get; set; }

/// <summary> <c>Inmortal</c> State </summary>

public bool Inmortal{ get; set; }

/// <summary> <c>Towering Wisdom</c> State </summary>

public bool ToweringWisdom{ get; set; }

/// <summary> <c>Mustache Mode</c> State </summary>

public bool MustacheMode{ get; set; }

/// <summary> Creates a new instance of <c>AchievementsInfo</c> </summary>

public AchievementsInfo()
{
}

// Read State

private static bool ReadState(Stream reader) => reader.ReadUInt16() != 0;

// Read data from BinaryStream

public static AchievementsInfo ReadBin(Stream reader)
{

return new()
{
HomeSecurity = ReadState(reader),
NobelPeas = ReadState(reader),
Better_Off_Dead = ReadState(reader),
ChinaShop = ReadState(reader),
Spudow = ReadState(reader),
Explodonator = ReadState(reader),
Morticulturalist = ReadState(reader),
DontPInPool = ReadState(reader),
Roll_Some_Heads = ReadState(reader),
Grounded = ReadState(reader),
Zombologist = ReadState(reader),
PennyPincher = ReadState(reader),
SunnyDays = ReadState(reader),
PopcornParty = ReadState(reader),
GoodMorning = ReadState(reader),
No_Fungus_Among_Us = ReadState(reader),
BeyondGrave = ReadState(reader),
Inmortal = ReadState(reader),
ToweringWisdom = ReadState(reader),
MustacheMode = ReadState(reader)
};

}

// Write State

private static void WriteState(Stream writer, bool state) => writer.WriteUInt16( (ushort)(state ? 1u : 0u) );

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
WriteState(writer, HomeSecurity);
WriteState(writer, NobelPeas);
WriteState(writer, Better_Off_Dead);
WriteState(writer, ChinaShop);
WriteState(writer, Spudow);
WriteState(writer, Explodonator);
WriteState(writer, Morticulturalist);
WriteState(writer, DontPInPool);
WriteState(writer, Roll_Some_Heads);
WriteState(writer, Grounded);
WriteState(writer, Zombologist);
WriteState(writer, PennyPincher);
WriteState(writer, SunnyDays);
WriteState(writer, PopcornParty);
WriteState(writer, GoodMorning);
WriteState(writer, No_Fungus_Among_Us);
WriteState(writer, BeyondGrave);
WriteState(writer, Inmortal);
WriteState(writer, ToweringWisdom);
WriteState(writer, MustacheMode);
}

}

}