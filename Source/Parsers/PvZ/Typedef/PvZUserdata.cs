using System;
using System.IO;
using System.Text.Json.Serialization;

namespace SaveConverter.PvZ
{
/// <summary> Represents a Data Container for a PvZ Profile </summary>

public class PvZUserdata
{
/// <summary> Identifier for Game version </summary>

public PvZVersion Version{ get; set; }

/// <summary> Current Level </summary>

public CurrentLevelID CurrentLevel{ get; set; }

/// <summary> Amount of Coins divided by 10 </summary>

public int Coins{ get; set; }

/// <summary> Number of times Adventure Mode completed </summary>

public uint AdventuresCompleted{ get; set; }

/// <summary> Flags attained in each Survival mode </summary>

public SurvivalModeInfo SurvivalData{ get; set; }

/// <summary> Trophies obtained in Minigames section </summary>

public MinigamesInfo MinigamesCompleted{ get; set; }

/// <summary> Trophies obtained in Minigames section </summary>

public LimboPageInfo MinigamesCompleted_Limbo{ get; set; }

/// <summary> Height of Tree of Wisdom in feet </summary>

public uint TreeWeight{ get; set; }

/// <summary> Puzzle records </summary>

public PuzzleModeInfo PuzzleData{ get; set; }

/// <summary> Upsell Trophy (Limbo Page) </summary>

public bool Limbo_Upsell{ get; set; }

/// <summary> Intro Trophy (Limbo Page) </summary>

public bool Limbo_Intro{ get; set; }

/// <summary> Items bought in Dave's Shop </summary>

public DaveShopInfo ItemsBought{ get; set; }

/// <summary> Play Anim when Almanac is Unlocked </summary>

public bool AlmanacUnlockedAnim{ get; set; }

/// <summary> Last time when Stinky the Snail was fed with Chocolate </summary>

public DateTime SnailLastChocolateTime{ get; set; }

/// <summary> Position of Stinky the Snail </summary>

public SexyPoint SnailPos{ get; set; }

/// <summary> Determines if Minigames are Unlocked or not </summary>

public bool MinigamesUnlocked{ get; set; }

/// <summary> Determines if Puzzles are Unlocked or not </summary>

public bool PuzzlesUnlocked{ get; set; }

/// <summary> Animations Played </summary>

public AnimPlayInfo AnimsPlayed{ get; set; }

/// <summary> Has <c>Taco</c> </summary>

public bool HasTaco{ get; set; }

/// <summary> Zen Garden Data </summary>

public ZenGardenInfo ZenGardenData{ get; set; }

/// <summary> Achievements unlocked </summary>

public AchievementsInfo Achievements{ get; set; }

/// <summary> Zombatar Data </summary>

public ZombatarInfo ZombatarData{ get; set; }

/// <summary> Creates a new instance of <c>PvZUserdata</c> </summary>

public PvZUserdata()
{
SurvivalData = new();

MinigamesCompleted = new();
MinigamesCompleted_Limbo = new();

PuzzleData = new();
ItemsBought = new();

AnimsPlayed = new();
ZenGardenData = new();

Achievements = new();
ZombatarData = new();
}

public static readonly JsonSerializerContext Context = new PvZUserdataContext(JsonSerializer.Options);

// Read Userdata from BinaryStream

public static PvZUserdata ReadBin(Stream reader)
{

PvZUserdata userdata = new()
{
Version = (PvZVersion)reader.ReadUInt32(),
CurrentLevel = (CurrentLevelID)reader.ReadUInt32(),
Coins = reader.ReadInt32() * 10,
AdventuresCompleted = reader.ReadUInt32(),
SurvivalData = SurvivalModeInfo.ReadBin(reader),
MinigamesCompleted = MinigamesInfo.ReadBin(reader),
MinigamesCompleted_Limbo = LimboPageInfo.ReadBin(reader),
TreeWeight = reader.ReadUInt32(),
PuzzleData = PuzzleModeInfo.ReadBin(reader),
Limbo_Upsell = Boolean32.Read(reader),
Limbo_Intro = Boolean32.Read(reader)
};

using var unknown = reader.ReadPtr(112); // Unknown section: 0x130 - 0x19F

userdata.ItemsBought = DaveShopInfo.ReadBin(reader);

using var unknown2 = reader.ReadPtr(216); // Unknown section: 0x218 - 0x2EF

userdata.AlmanacUnlockedAnim = Boolean32.Read(reader);
userdata.SnailLastChocolateTime = UnixHelper.Read(reader);
userdata.SnailPos = SexyPoint.Read(reader);
userdata.MinigamesUnlocked = Boolean32.Read(reader);
userdata.PuzzlesUnlocked = Boolean32.Read(reader);
userdata.AnimsPlayed = AnimPlayInfo.ReadBin(reader);
userdata.HasTaco = Boolean32.Read(reader);
userdata.ZenGardenData = ZenGardenInfo.ReadBin(reader);

// NOTE: some Fields might not be Present in save

if(reader.Position < reader.Length)
{
userdata.Achievements = AchievementsInfo.ReadBin(reader);
userdata.ZombatarData = ZombatarInfo.ReadBin(reader);
}

return userdata;
}

// Write Userdata to BinaryStream

public void WriteBin(Stream writer)
{
writer.WriteUInt32( (uint)Version);
writer.WriteUInt32( (uint)CurrentLevel);

writer.WriteInt32(Coins / 10);
writer.WriteUInt32(AdventuresCompleted);

SurvivalData.WriteBin(writer);
MinigamesCompleted.WriteBin(writer);
MinigamesCompleted_Limbo.WriteBin(writer);

writer.WriteUInt32(TreeWeight);

PuzzleData.WriteBin(writer);

Boolean32.Write(writer, Limbo_Upsell);
Boolean32.Write(writer, Limbo_Intro);

writer.Fill(112);

ItemsBought.WriteBin(writer);

writer.Fill(216);

Boolean32.Write(writer, AlmanacUnlockedAnim);
UnixHelper.Write(writer, SnailLastChocolateTime);

SnailPos.Write(writer);

Boolean32.Write(writer, MinigamesUnlocked);
Boolean32.Write(writer, PuzzlesUnlocked);

AnimsPlayed.WriteBin(writer);

Boolean32.Write(writer, HasTaco);

ZenGardenData.WriteBin(writer);
Achievements.WriteBin(writer);
ZombatarData.WriteBin(writer);
}

}

// Context for Serialization

[JsonSerializable(typeof(DateTime), TypeInfoPropertyName = "DateTime")]
[JsonSerializable(typeof(SexyPoint))]

[JsonSerializable(typeof(SurvivalModeInfo))]

[JsonSerializable(typeof(MinigamesInfo))]
[JsonSerializable(typeof(LimboPageInfo))]
[JsonSerializable(typeof(DaveShopInfo))]

[JsonSerializable(typeof(AnimPlayInfo))]
[JsonSerializable(typeof(ZenGardenInfo))]
[JsonSerializable(typeof(ZombatarInfo))]

public partial class PvZUserdataContext : JsonSerializerContext
{
}

}