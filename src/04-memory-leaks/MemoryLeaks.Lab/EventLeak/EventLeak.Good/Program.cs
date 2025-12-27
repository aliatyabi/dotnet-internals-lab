namespace MemoryLeaks.Lab.EventLeak;

class Program
{
    private static Publisher publisher = new Publisher();

    public static void Main(string[] args)
    {
        Console.WriteLine("=== GOOD VERSION (Event without Memory Leak) ===");

        CreateSubscribers();

        ForceGC();

        Console.WriteLine("GC forced. Subscribers are eligible for collection.");
        Console.ReadLine();
    }

    private static void CreateSubscribers()
    {
        for (int i = 1; i <= 5; i++)
        {
            using var subscriber = new Subscriber(publisher, i);
        }
    }

    private static void ForceGC()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}
