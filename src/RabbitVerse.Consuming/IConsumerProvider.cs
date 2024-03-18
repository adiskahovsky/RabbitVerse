namespace RabbitVerse.Consuming
{
    public interface IConsumerProvider
    {

        ConsumerInfo Get(string exchange);
        HashSet<ConsumerInfo> Get();
    }
}