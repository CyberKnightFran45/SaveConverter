using System.IO;
using System.Text.Json.Serialization;

namespace SaveConverter.PvZ
{
/// <summary> Records for Puzzle Mode </summary>

public class PuzzleModeInfo
{
/// <summary> Progress for Vasebreaker </summary>

public PuzzleRecord Vasebreaker{ get; set; }

/// <summary> Progress for I, Zombie </summary>

public PuzzleRecord IZombie{ get; set; }

/// <summary> Creates a new instance of <c>PuzzleModeInfo</c> </summary>

public PuzzleModeInfo()
{
Vasebreaker = new();
IZombie = new();
}

public static readonly JsonSerializerContext Context = new SurvivalDataContext(JsonSerializer.Options);

// Read data from BinaryStream

public static PuzzleModeInfo ReadBin(Stream reader)
{

return new()
{
Vasebreaker = PuzzleRecord.ReadBin(reader),
IZombie = PuzzleRecord.ReadBin(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
Vasebreaker.WriteBin(writer);
IZombie.WriteBin(writer);
}

}

// Context for Serialization

[JsonSerializable(typeof(PuzzleRecord))]

public partial class PuzzleDataContext : JsonSerializerContext
{
}

}