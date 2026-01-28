using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Stores Progress in Survival Mode </summary>

public class SurvivalRecord
{
/// <summary> Flags attained at Survival: Day </summary>

public uint Day{ get; set; }

/// <summary> Flags attained at Survival: Night </summary>

public uint Night{ get; set; }

/// <summary> Flags attained at Survival: Pool </summary>

public uint Pool{ get; set; }

/// <summary> Flags attained at Survival: Fog </summary>

public uint Fog{ get; set; }

/// <summary> Flags attained at Survival: Roof </summary>

public uint Roof{ get; set; }

/// <summary> Creates a new instance of <c>SurvivalRecord</c> </summary>

public SurvivalRecord()
{
}

// Read record from BinaryStream

public static SurvivalRecord ReadBin(Stream reader)
{

return new()
{
Day = reader.ReadUInt32(),
Night = reader.ReadUInt32(),
Pool = reader.ReadUInt32(),
Fog = reader.ReadUInt32(),
Roof = reader.ReadUInt32()
};

}

// Write record to BinaryStream

public void WriteBin(Stream writer)
{
writer.WriteUInt32(Day);
writer.WriteUInt32(Night);
writer.WriteUInt32(Pool);
writer.WriteUInt32(Fog);
writer.WriteUInt32(Roof);
}

}

}