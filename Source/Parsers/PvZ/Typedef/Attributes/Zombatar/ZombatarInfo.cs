using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace SaveConverter.PvZ
{
/// <summary> Stores info about Player's Zombatars </summary>

public class ZombatarInfo
{
/// <summary> Determines if User accepted Zombatar license agreement </summary>

public bool AgreementAccepted{ get; set; }

/// <summary> List of Zombatars created </summary>

public List<ZombatarEntry> Zombatars{ get; set; }

/// <summary> Determines if User has Created at Least one Zombatar </summary>

public bool HasCreatedZombatar{ get; set; }

/// <summary> Creates a new instance of <c>ZombatarInfo</c> </summary>

public ZombatarInfo()
{
Zombatars = new();
}

/// <summary> Creates a new instance of <c>ZombatarInfo</c> </summary>

public ZombatarInfo(bool agreement, List<ZombatarEntry> entries, bool ignoreDialog)
{
AgreementAccepted = agreement;

Zombatars = entries;
HasCreatedZombatar = ignoreDialog;
}

public static readonly JsonSerializerContext Context = new ZombatarContext(JsonSerializer.Options);

// Read data from BinaryStream

public static ZombatarInfo ReadBin(Stream reader)
{
bool agreement = reader.ReadBool();
var entries = ZombatarEntry.ReadAll(reader);

using var unknown = reader.ReadPtr(20); // Unknown section: 0x00 - 0x13

bool ignoreDialog = reader.ReadBool();

return new(agreement, entries, ignoreDialog);
}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
writer.WriteBool(AgreementAccepted);
ZombatarEntry.WriteAll(writer, Zombatars);

writer.Fill(20);

writer.WriteBool(HasCreatedZombatar);
}

}

// Context for Serialization

[JsonSerializable(typeof(ZombatarEntry))]
[JsonSerializable(typeof(List<ZombatarEntry>))]

public partial class ZombatarContext : JsonSerializerContext
{
}

}