namespace MemoryLeaks.Lab.AsyncLeak;

internal class ProgramGood
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("=== GOOD VERSION (Async without Memory Retention) ===");

        await SafeAsync();

        ForceGC();

        Console.WriteLine("GC forced. Large object CAN be collected.");
        Console.ReadLine();
    }

    private static async Task SafeAsync()
    {
        {
            var largeBuffer = LargeObjectProvider.CreateLargeBuffer();
            Console.WriteLine("Large buffer allocated");

            Console.WriteLine($"Buffer size: {largeBuffer.Length}");
        }

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
