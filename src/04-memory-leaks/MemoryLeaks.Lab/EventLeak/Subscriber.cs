namespace MemoryLeaks.Lab.EventLeak
{
    public class Subscriber
    {
        private readonly int _id;

        public Subscriber(Publisher publisher, int id)
        {
            _id = id;
            publisher.OnMessage += Handle;
        }

        private void Handle()
        {
            Console.WriteLine($"Subscriber {_id} received message");
        }
    }

}
