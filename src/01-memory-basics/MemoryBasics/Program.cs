using MemoryBasics;

Console.WriteLine("=== .NET 8 Memory Basics ===");

MeasureStructAllocation();
MeasureClassAllocation();

static void MeasureStructAllocation()
{
    GC.Collect();
    GC.WaitForPendingFinalizers();
    GC.Collect();

    long before = GC.GetTotalMemory(true);

    for (int i = 0; i < 10_000_000; i++)
    {
        PointStruct p = new PointStruct { X = i, Y = i };
    }

    long after = GC.GetTotalMemory(true);

    Console.WriteLine($"Struct allocation: {after - before} bytes");
}

static void MeasureClassAllocation()
{
    GC.Collect();
    GC.WaitForPendingFinalizers();
    GC.Collect();

    long before = GC.GetTotalMemory(true);

    for (int i = 0; i < 10_000_000; i++)
    {
        PointClass p = new PointClass { X = i, Y = i };
    }

    long after = GC.GetTotalMemory(true);

    Console.WriteLine($"Class allocation: {after - before} bytes");
}
