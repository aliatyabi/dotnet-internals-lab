namespace MemoryLeaks.Lab.EventLeak
{
    public class Subscriber : IDisposable
    {
        private readonly int _id;
        private bool _disposed;
        private readonly Publisher _publisher;

        public Subscriber(Publisher publisher, int id)
        {
            _publisher = publisher;
            _id = id;

            publisher.OnMessage += Handle;
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            _publisher.OnMessage -= Handle;

            _disposed = true;
            Console.WriteLine($"Subscriber {_id} disposed and unsubscribed");
        }

        private void Handle()
        {
            Console.WriteLine($"Subscriber {_id} received message");
        }
    }

}
