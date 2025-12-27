namespace MemoryLeaks.Lab.AsyncLeak;

public static class LargeObjectProvider
{
    public static byte[] CreateLargeBuffer()
    {
        // ~50 MB → روی LOH
        return new byte[50_000_000];
    }
}

