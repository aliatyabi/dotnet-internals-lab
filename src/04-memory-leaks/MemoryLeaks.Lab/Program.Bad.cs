using MemoryLeaks.Lab.EventLeak;

class ProgramBad
{
    static Publisher publisher = new Publisher();

    static void Main()
    {
        CreateSubscribers();

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Console.WriteLine("GC forced. Subscribers should be gone but they don't.");
        Console.ReadLine();
    }

    static void CreateSubscribers()
    {
        for (int i = 0; i < 5; i++)
        {
            new Subscriber(publisher, i);
        }
    }
}
