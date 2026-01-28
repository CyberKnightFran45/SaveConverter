using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Stores Info about which Animations should be Played </summary>

public class AnimPlayInfo
{
/// <summary> Animate unlocking of last unlocked <c>Minigame</c> </summary>

public bool LastLevelUnlocked_Minigames{ get; set; }

/// <summary> Animate unlocking of last unlocked level: <c>Vasebreaker</c> </summary>

public bool LastLevelUnlocked_Vasebreaker{ get; set; }

/// <summary> Animate unlocking of last unlocked level: <c>I, Zombie</c> </summary>

public bool LastLevelUnlocked_IZombie{ get; set; }

/// <summary> Animate unlocking of last unlocked level: <c>Survival Mode</c> </summary>

public bool LastLevelUnlocked_Survival{ get; set; }

/// <summary> Animate unlocking of last level unlocked: <c>Limbo Page</c> (unused) </summary>

public bool LastLevelUnlocked_Limbo{ get; set; }

/// <summary> Show <c>Adventure Complete!</c> dialog on next visit to Main Menu </summary>

public bool AdventureComplete{ get; set; }

/// <summary> Creates a new instance of <c>AnimPlayInfo</c> </summary>

public AnimPlayInfo()
{
}

// Read data from BinaryStream

public static AnimPlayInfo ReadBin(Stream reader)
{

return new()
{
LastLevelUnlocked_Minigames = Boolean32.Read(reader),
LastLevelUnlocked_Vasebreaker = Boolean32.Read(reader),
LastLevelUnlocked_IZombie = Boolean32.Read(reader),
LastLevelUnlocked_Survival = Boolean32.Read(reader),
LastLevelUnlocked_Limbo = Boolean32.Read(reader),
AdventureComplete = Boolean32.Read(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
Boolean32.Write(writer, LastLevelUnlocked_Minigames);
Boolean32.Write(writer, LastLevelUnlocked_Vasebreaker);
Boolean32.Write(writer, LastLevelUnlocked_IZombie);
Boolean32.Write(writer, LastLevelUnlocked_Survival);
Boolean32.Write(writer, LastLevelUnlocked_Limbo);
Boolean32.Write(writer, AdventureComplete);
}

}

}