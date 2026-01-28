using System.IO;

/// <summary> Helper for handling Offsets as Int32 </summary>

public static class Offset32
{
// Read

public static int? Read(Stream reader, int offset)
{
int v = reader.ReadInt32();

return v == 0 ? null : (int?)(v - offset);
}

// Write

public static void Write(Stream writer, int? v, int offset) => writer.WriteInt32(v is null ? 0 : (int)v + offset);
}