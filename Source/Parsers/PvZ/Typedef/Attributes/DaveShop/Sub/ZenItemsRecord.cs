using System;
using System.IO;

namespace SaveConverter.PvZ
{
/// <summary> Records Item States for Zen Garden </summary>

public class ZenItemsRecord
{
// 2000

private static readonly DateTime y2k = new(2000, 1, 1);

/// <summary> Days since left Marigold was Purchased from Store </summary>

public DateTime? MarigoldLastPurchased_L{ get; set; }

/// <summary> Days since center Marigold was Purchased from Store </summary>

public DateTime? MarigoldLastPurchased{ get; set; }

/// <summary> Days since right Marigold was Purchased from Store </summary>

public DateTime? MarigoldLastPurchased_R{ get; set; }

/// <summary> <c>Gold Watering Can</c> Sale State </summary>

public bool GoldCan{ get; set; }

/// <summary> Amount of Fertilizer </summary>

public int? Fertilizer{ get; set; }

/// <summary> Amount of Bug Spray </summary>

public int? BugSpray{ get; set; }

/// <summary> <c>Phonograph</c> Sale State </summary>

public bool Phonograph{ get; set; }

/// <summary> <c>Gardening Glove</c> Sale State </summary>

public bool GardenGlove{ get; set; }

/// <summary> <c>Mushroom Garden</c> Sale State </summary>

public bool MushroomGarden{ get; set; }

/// <summary> <c>Wheel Barrow</c> Sale State </summary>

public bool WheelBarrow{ get; set; }

/// <summary> Last time when Stinky the Snail awoken </summary>

public DateTime SnailLastAwakeTime{ get; set; }

/// <summary> Creates a new instance of <c>ZenItemsRecord</c> </summary>

public ZenItemsRecord()
{
}

// Read DateTime as a int32

private static DateTime? ReadDT32(Stream reader)
{
uint days = reader.ReadUInt32();

if(days == 0)
return null;

return y2k.AddDays(days);
}

// Read data from BinaryStream

public static ZenItemsRecord ReadBin(Stream reader)
{

return new()
{
MarigoldLastPurchased_L = ReadDT32(reader),
MarigoldLastPurchased = ReadDT32(reader),
MarigoldLastPurchased_R = ReadDT32(reader),
GoldCan = Boolean32.Read(reader),
Fertilizer = Offset32.Read(reader, 1000),
BugSpray = Offset32.Read(reader, 1000),
Phonograph = Boolean32.Read(reader),
GardenGlove = Boolean32.Read(reader),
MushroomGarden = Boolean32.Read(reader),
WheelBarrow = Boolean32.Read(reader),
SnailLastAwakeTime = UnixHelper.Read(reader)
};

}

// Write DateTime as a int32

private static void WriteDT32(Stream writer, DateTime? date)
{
uint days;

if(date is null)
days = 0;

else
{
var dt = (DateTime)date;

days = (uint)dt.Subtract(y2k).TotalDays;
}

writer.WriteUInt32(days);
}

// Write data to BinaryStream

public void WriteBin(Stream writer)
{
WriteDT32(writer, MarigoldLastPurchased_L);
WriteDT32(writer, MarigoldLastPurchased);
WriteDT32(writer, MarigoldLastPurchased_R);

Boolean32.Write(writer, GoldCan);

Offset32.Write(writer, Fertilizer, 1000);
Offset32.Write(writer, BugSpray, 1000);

Boolean32.Write(writer, Phonograph);
Boolean32.Write(writer, GardenGlove);
Boolean32.Write(writer, MushroomGarden);
Boolean32.Write(writer, WheelBarrow);

UnixHelper.Write(writer, SnailLastAwakeTime);
}

}

}