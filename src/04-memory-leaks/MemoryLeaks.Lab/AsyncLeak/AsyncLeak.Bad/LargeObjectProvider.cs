namespace MemoryLeaks.Lab.AsyncLeak;

public static class LargeObjectProvider
{
    public static byte[] CreateLargeBuffer()
    {
        return new byte[50_000_000];
    }
}

