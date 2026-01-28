using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Stores Progress for Puzzle Mode </summary>

public class PuzzleRecord
{
/// <summary> <c>Puzzle1</c> Completion State </summary>

public bool Puzzle1{ get; set; }

/// <summary> <c>Puzzle2</c> Completion State </summary>

public bool Puzzle2{ get; set; }

/// <summary> <c>Puzzle3</c> Completion State </summary>

public bool Puzzle3{ get; set; }

/// <summary> <c>Puzzle4</c> Completion State </summary>

public bool Puzzle4{ get; set; }

/// <summary> <c>Puzzle5</c> Completion State </summary>

public bool Puzzle5{ get; set; }

/// <summary> <c>Puzzle6</c> Completion State </summary>

public bool Puzzle6{ get; set; }

/// <summary> <c>Puzzle7</c> Completion State </summary>

public bool Puzzle7{ get; set; }

/// <summary> <c>Puzzle8</c> Completion State </summary>

public bool Puzzle8{ get; set; }

/// <summary> <c>Puzzle9</c> Completion State </summary>

public bool Puzzle9{ get; set; }

/// <summary> Streak for Endless Mode </summary>

public uint EndlessStreak{ get; set; }

/// <summary> Creates a new instance of <c>PuzzleRecord</c> </summary>

public PuzzleRecord()
{
}

// Read data from BinaryStream

public static PuzzleRecord ReadBin(Stream reader)
{

return new()
{
Puzzle1 = Boolean32.Read(reader),
Puzzle2 = Boolean32.Read(reader),
Puzzle3 = Boolean32.Read(reader),
Puzzle4 = Boolean32.Read(reader),
Puzzle5 = Boolean32.Read(reader),
Puzzle6 = Boolean32.Read(reader),
Puzzle7 = Boolean32.Read(reader),
Puzzle8 = Boolean32.Read(reader),
Puzzle9 = Boolean32.Read(reader),
EndlessStreak = reader.ReadUInt32()
};

}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
Boolean32.Write(writer, Puzzle1);
Boolean32.Write(writer, Puzzle2);
Boolean32.Write(writer, Puzzle3);
Boolean32.Write(writer, Puzzle4);
Boolean32.Write(writer, Puzzle5);
Boolean32.Write(writer, Puzzle6);
Boolean32.Write(writer, Puzzle7);
Boolean32.Write(writer, Puzzle8);
Boolean32.Write(writer, Puzzle9);

writer.WriteUInt32(EndlessStreak);
}

}

}