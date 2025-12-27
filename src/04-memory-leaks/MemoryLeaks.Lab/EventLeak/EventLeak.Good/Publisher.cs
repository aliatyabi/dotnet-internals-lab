namespace MemoryLeaks.Lab.EventLeak
{
    public class Publisher
    {
        public event Action? OnMessage;

        public void Raise()
        {
            OnMessage?.Invoke();
        }
    }

}
