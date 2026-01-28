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

// Read data from BinaryStream

public static AchievementsInfo ReadBin(Stream reader)
{

return new()
{
HomeSecurity = Boolean16.Read(reader),
NobelPeas = Boolean16.Read(reader),
Better_Off_Dead = Boolean16.Read(reader),
ChinaShop = Boolean16.Read(reader),
Spudow = Boolean16.Read(reader),
Explodonator = Boolean16.Read(reader),
Morticulturalist = Boolean16.Read(reader),
DontPInPool = Boolean16.Read(reader),
Roll_Some_Heads = Boolean16.Read(reader),
Grounded = Boolean16.Read(reader),
Zombologist = Boolean16.Read(reader),
PennyPincher = Boolean16.Read(reader),
SunnyDays = Boolean16.Read(reader),
PopcornParty = Boolean16.Read(reader),
GoodMorning = Boolean16.Read(reader),
No_Fungus_Among_Us = Boolean16.Read(reader),
BeyondGrave = Boolean16.Read(reader),
Inmortal = Boolean16.Read(reader),
ToweringWisdom = Boolean16.Read(reader),
MustacheMode = Boolean16.Read(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
Boolean16.Write(writer, HomeSecurity);
Boolean16.Write(writer, NobelPeas);
Boolean16.Write(writer, Better_Off_Dead);
Boolean16.Write(writer, ChinaShop);
Boolean16.Write(writer, Spudow);
Boolean16.Write(writer, Explodonator);
Boolean16.Write(writer, Morticulturalist);
Boolean16.Write(writer, DontPInPool);
Boolean16.Write(writer, Roll_Some_Heads);
Boolean16.Write(writer, Grounded);
Boolean16.Write(writer, Zombologist);
Boolean16.Write(writer, PennyPincher);
Boolean16.Write(writer, SunnyDays);
Boolean16.Write(writer, PopcornParty);
Boolean16.Write(writer, GoodMorning);
Boolean16.Write(writer, No_Fungus_Among_Us);
Boolean16.Write(writer, BeyondGrave);
Boolean16.Write(writer, Inmortal);
Boolean16.Write(writer, ToweringWisdom);
Boolean16.Write(writer, MustacheMode);
}

}

}