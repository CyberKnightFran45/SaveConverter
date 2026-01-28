using System.IO;

/// <summary> Helper for handling Booleans as Int32 </summary>

public static class Boolean32
{
// Read

public static bool Read(Stream reader) => reader.ReadInt32() != 0;

// Write

public static void Write(Stream writer, bool v) => writer.WriteUInt32(v ? 1u : 0u);
}