using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Records which Minigames were Completed in Limbo Page </summary>

public class LimboPageInfo
{
/// <summary> Hidden Minigame: <c>Art Challenge Wall-nut</c> </summary>

public bool Art_WallNut{ get; set; }

/// <summary> Hidden Minigame: <c>Sunny Day</c> </summary>

public bool SunnyDay{ get; set; }

/// <summary> Hidden Minigame: <c>Unsodded</c> </summary>

public bool Unsodded{ get; set; }

/// <summary> Hidden Minigame: <c>Big Time</c> </summary>

public bool BigTime{ get; set; }

/// <summary> Hidden Minigame: <c>Art Challenge Sunflower</c> </summary>

public bool Art_Sunflower{ get; set; }

/// <summary> Hidden Minigame: <c>Air Raid</c> </summary>

public bool Air_Raid{ get; set; }

/// <summary> Hidden Minigame: <c>Ice Level</c> </summary>

public bool IceLevel{ get; set; }

/// <summary> Zen Garden Trophy (Limbo Page) </summary>

public bool Limbo_ZenGarden{ get; set; }

/// <summary> Hidden Minigame: <c>High Gravity</c> </summary>

public bool HighGravity{ get; set; }

/// <summary> Hidden Minigame: <c>Grave Danger</c> </summary>

public bool GraveDanger{ get; set; }

/// <summary> Hidden Minigame: <c>Can You Dig It?</c> </summary>

public bool CanUDigIt{ get; set; }

/// <summary> Hidden Minigame: <c>Dark Stormy Night</c> </summary>

public bool Dark_Stormy_Night{ get; set; }

/// <summary> Hidden Minigame: <c>Bungee Blitz</c> </summary>

public bool BungeeBlitz{ get; set; }

/// <summary> Hidden Minigame: <c>Squirrel</c> </summary>

public bool Squirrel{ get; set; }

/// <summary> Creates a new instance of <c>LimboPageInfo</c> </summary>

public LimboPageInfo()
{
}

// Read data from BinaryStream

public static LimboPageInfo ReadBin(Stream reader)
{

return new()
{
Art_WallNut = Boolean32.Read(reader),
SunnyDay = Boolean32.Read(reader),
Unsodded = Boolean32.Read(reader),
BigTime = Boolean32.Read(reader),
Art_Sunflower = Boolean32.Read(reader),
Air_Raid = Boolean32.Read(reader),
IceLevel = Boolean32.Read(reader),
Limbo_ZenGarden = Boolean32.Read(reader),
HighGravity = Boolean32.Read(reader),
GraveDanger = Boolean32.Read(reader),
CanUDigIt = Boolean32.Read(reader),
Dark_Stormy_Night = Boolean32.Read(reader),
BungeeBlitz = Boolean32.Read(reader),
Squirrel = Boolean32.Read(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
Boolean32.Write(writer, Art_WallNut);
Boolean32.Write(writer, SunnyDay);
Boolean32.Write(writer, Unsodded);
Boolean32.Write(writer, BigTime);
Boolean32.Write(writer, Art_Sunflower);
Boolean32.Write(writer, Air_Raid);
Boolean32.Write(writer, IceLevel);
Boolean32.Write(writer, Limbo_ZenGarden);
Boolean32.Write(writer, HighGravity);
Boolean32.Write(writer, GraveDanger);
Boolean32.Write(writer, CanUDigIt);
Boolean32.Write(writer, Dark_Stormy_Night);
Boolean32.Write(writer, BungeeBlitz);
Boolean32.Write(writer, Squirrel);
}

}

}