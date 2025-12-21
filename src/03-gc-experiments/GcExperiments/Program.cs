using System;

class BigObject
{
    public byte[] Data = new byte[1024 * 1024]; // ~1MB
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Start");

        CreateObjects();

        Console.WriteLine("Forcing GC...");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Console.WriteLine("GC completed");
        Console.WriteLine($"Generation: {GC.GetGeneration(_root)}");
        Console.ReadLine();
    }

    static BigObject? _root;

    static void CreateObjects()
    {
        _root = new BigObject();
        Console.WriteLine("Object rooted");
    }
}
