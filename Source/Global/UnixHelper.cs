using System;
using System.IO;
using SexyCalculator;

/// <summary> Helper for handling Unix Timestamps </summary>

public static class UnixHelper
{
// Read

public static DateTime Read(Stream reader)
{
uint v = reader.ReadUInt32();

return UnixTimestamp.ConvertFrom(v);
}

// Write

public static void Write(Stream writer, DateTime d)
{
var v = (uint)UnixTimestamp.ConvertTo(d);

writer.WriteUInt32(v);
}

}