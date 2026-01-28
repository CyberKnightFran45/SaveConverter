using System.IO;
using System.Text.Json.Serialization;

namespace SaveConverter.PvZ
{
/// <summary> Records for Flags in Survival Mode </summary>

public class SurvivalModeInfo
{
/// <summary> Progress for Survival </summary>

public SurvivalRecord Progress{ get; set; }

/// <summary> Progress for Survival (Hard) </summary>

public SurvivalRecord Progress_Hard{ get; set; }

/// <summary> Progress for Survival (Endless) </summary>

public SurvivalRecord Progress_Endless{ get; set; }

/// <summary> Creates a new instance of <c>SurvivalModeInfo</c> </summary>

public SurvivalModeInfo()
{
Progress = new();

Progress_Hard = new();
Progress_Endless = new();
}

public static readonly JsonSerializerContext Context = new SurvivalDataContext(JsonSerializer.Options);

// Read data from BinaryStream

public static SurvivalModeInfo ReadBin(Stream reader)
{

return new()
{
Progress = SurvivalRecord.ReadBin(reader),
Progress_Hard = SurvivalRecord.ReadBin(reader),
Progress_Endless = SurvivalRecord.ReadBin(reader)
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
Progress.WriteBin(writer);
Progress_Hard.WriteBin(writer);
Progress_Endless.WriteBin(writer);
}

}

// Context for Serialization

[JsonSerializable(typeof(SurvivalRecord))]

public partial class SurvivalDataContext : JsonSerializerContext
{
}

}