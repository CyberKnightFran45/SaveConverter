using System.IO;

/// <summary> Helper for handling Booleans as Int16 </summary>

public static class Boolean16
{
// Read

public static bool Read(Stream reader) => reader.ReadInt16() != 0;

// Write

public static void Write(Stream writer, bool v) => writer.WriteUInt16( (ushort)(v ? 1u : 0u) );
}