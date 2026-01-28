using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Records which Minigames were Completed </summary>

public class MinigamesInfo
{
/// <summary> <c>ZomBotany</c> Completion State </summary>

public bool ZomBotany{ get; set; }

/// <summary> <c>Wall-nut Bowling</c> Completion State </summary>

public bool WallNut_Bowling{ get; set; }

/// <summary> <c>Slot Machine</c> Completion State </summary>

public bool SlotMachine{ get; set; }

/// <summary> <c>It's Raining Seeds</c> Completion State </summary>

public bool Its_Raining_Seeds{ get; set; }

/// <summary> <c>Beghouled</c> Completion State </summary>

public bool Beghouled{ get; set; }

/// <summary> <c>Invisi-ghoul</c> Completion State </summary>

public bool Invisighoul{ get; set; }

/// <summary> <c>Seeing Stars</c> Completion State </summary>

public bool Seeing_Stars{ get; set; }

/// <summary> <c>Zombiquarium</c> Completion State </summary>

public bool Zombiquarium{ get; set; }

/// <summary> <c>Beghouled Twist</c> Completion State </summary>

public bool BeghouledTwist{ get; set; }

/// <summary> <c>Big Trouble, Little Zombie</c> Completion State </summary>

public bool LittleTrouble{ get; set; }

/// <summary> <c>Portal Combat</c> Completion State </summary>

public bool PortalCombat{ get; set; }

/// <summary> <c>Column Like You See 'Em</c> Completion State </summary>

public bool ColumnAsUCM{ get; set; }

/// <summary> <c>Bobsled Bonanza</c> Completion State </summary>

public bool Bobsled_Bonanza{ get; set; }

/// <summary> <c>Zombie Nimble Zombie Quick</c> Completion State </summary>

public bool ZombiesOnSpeed{ get; set; }

/// <summary> <c>Whack a Zombie</c> Completion State </summary>

public bool WhackAZombie{ get; set; }

/// <summary> <c>Last Stand</c> Completion State </summary>

public bool LastStand{ get; set; }

/// <summary> <c>ZomBotany 2</c> Completion State </summary>

public bool ZomBotany_2{ get; set; }

/// <summary> <c>Wall-nut Bowling 2</c> Completion State </summary>

public bool WallNut_Bowling_2{ get; set; }

/// <summary> <c>Pogo Party</c> Completion State </summary>

public bool PogoParty{ get; set; }

/// <summary> <c>Dr. Zomboss Revenge</c> Completion State </summary>

public bool FinalBoss{ get; set; }

/// <summary> Creates a new instance of <c>MinigamesInfo</c> </summary>

public MinigamesInfo()
{
}

// Read data from BinaryStream

public static MinigamesInfo ReadBin(Stream reader)
{

return new()
{
ZomBotany = Boolean32.Read(reader),
WallNut_Bowling = Boolean32.Read(reader),
SlotMachine = Boolean32.Read(reader),
Its_Raining_Seeds = Boolean32.Read(reader),
Beghouled = Boolean32.Read(reader),
Invisighoul = Boolean32.Read(reader),
Seeing_Stars = Boolean32.Read(reader),
Zombiquarium = Boolean32.Read(reader),
BeghouledTwist = Boolean32.Read(reader),
LittleTrouble = Boolean32.Read(reader),
PortalCombat = Boolean32.Read(reader),
ColumnAsUCM = Boolean32.Read(reader),
Bobsled_Bonanza = Boolean32.Read(reader),
ZombiesOnSpeed = Boolean32.Read(reader),
WhackAZombie = Boolean32.Read(reader),
LastStand = Boolean32.Read(reader),
ZomBotany_2 = Boolean32.Read(reader),
WallNut_Bowling_2 = Boolean32.Read(reader),
PogoParty = Boolean32.Read(reader),
FinalBoss = Boolean32.Read(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
Boolean32.Write(writer, ZomBotany);
Boolean32.Write(writer, WallNut_Bowling);
Boolean32.Write(writer, SlotMachine);
Boolean32.Write(writer, Its_Raining_Seeds);
Boolean32.Write(writer, Beghouled);
Boolean32.Write(writer, Invisighoul);
Boolean32.Write(writer, Seeing_Stars);
Boolean32.Write(writer, Zombiquarium);
Boolean32.Write(writer, BeghouledTwist);
Boolean32.Write(writer, LittleTrouble);
Boolean32.Write(writer, PortalCombat);
Boolean32.Write(writer, ColumnAsUCM);
Boolean32.Write(writer, Bobsled_Bonanza);
Boolean32.Write(writer, ZombiesOnSpeed);
Boolean32.Write(writer, WhackAZombie);
Boolean32.Write(writer, LastStand);
Boolean32.Write(writer, ZomBotany_2);
Boolean32.Write(writer, WallNut_Bowling_2);
Boolean32.Write(writer, PogoParty);
Boolean32.Write(writer, FinalBoss);
}

}

}