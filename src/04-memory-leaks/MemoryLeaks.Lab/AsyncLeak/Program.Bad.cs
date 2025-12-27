using System;
using System.Threading.Tasks;

namespace MemoryLeaks.Lab.AsyncLeak;

internal class ProgramBad
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("=== BAD VERSION (Async Memory Retention) ===");

        await LeakyAsync();

        ForceGC();

        Console.WriteLine("GC forced. Large object is STILL retained.");
        Console.ReadLine();
    }

    private static async Task LeakyAsync()
    {
        var largeBuffer = LargeObjectProvider.CreateLargeBuffer();
        Console.WriteLine("Large buffer allocated");

        await Task.Delay(TimeSpan.FromMinutes(1));

        Console.WriteLine("Async operation finished");
    }

    private static void ForceGC()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}
