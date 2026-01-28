using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Records which Plants were Bought </summary>

public class PlantStoreRecord
{
/// <summary> <c>Gatling Pea</c> Sale State </summary>

public bool GatlingPea{ get; set; }

/// <summary> <c>Twin Sunflower</c> Sale State </summary>

public bool TwinSunflower{ get; set; }

/// <summary> <c>Gloom-shroom</c> Sale State </summary>

public bool GloomShroom{ get; set; }

/// <summary> <c>Cattail</c> Sale State </summary>

public bool Cattail{ get; set; }

/// <summary> <c>Winter Melon</c> Sale State </summary>

public bool WinterMelon{ get; set; }

/// <summary> <c>Gold Magnet</c> Sale State </summary>

public bool GoldMagnet{ get; set; }

/// <summary> <c>Spikerock</c> Sale State </summary>

public bool Spikerock{ get; set; }

/// <summary> <c>Cob Cannon</c> Sale State </summary>

public bool CobCannon{ get; set; }

/// <summary> <c>Imitater</c> Sale State </summary>

public bool Imitater{ get; set; }

/// <summary> Creates a new instance of <c>PlantStoreRecord</c> </summary>

public PlantStoreRecord()
{
}

// Read data from BinaryStream

public static PlantStoreRecord ReadBin(Stream reader)
{

return new()
{
GatlingPea = Boolean32.Read(reader),
TwinSunflower = Boolean32.Read(reader),
GloomShroom = Boolean32.Read(reader),
Cattail = Boolean32.Read(reader),
WinterMelon = Boolean32.Read(reader),
GoldMagnet = Boolean32.Read(reader),
Spikerock = Boolean32.Read(reader),
CobCannon = Boolean32.Read(reader),
Imitater = Boolean32.Read(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
Boolean32.Write(writer, GatlingPea);
Boolean32.Write(writer, TwinSunflower);
Boolean32.Write(writer, GloomShroom);
Boolean32.Write(writer, Cattail);
Boolean32.Write(writer, WinterMelon);
Boolean32.Write(writer, GoldMagnet);
Boolean32.Write(writer, Spikerock);
Boolean32.Write(writer, CobCannon);
Boolean32.Write(writer, Imitater);
}

}

}