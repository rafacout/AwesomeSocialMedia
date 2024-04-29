using System.Text;
using AwesomeSocialMedia.Posts.Core.Events;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace AwesomeSocialMedia.Posts.Infrastructure.EventBus
{
    public class RabbitMqService : IEventBus
    {
        private readonly IModel _chanel;
        private const string Exchange = "post";

        public RabbitMqService()
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };
            
            var connection = connectionFactory.CreateConnection("posts.publisher");
            
            _chanel = connection.CreateModel();
            
            _chanel .ExchangeDeclare(Exchange, ExchangeType.Direct, true, false);
        }

        public void Publish<T>(T @event) where T : IEvent
        {
            // Example: PostCRested => post-created
            var routingKey = @event.GetType().Name.ToDashCase();
            var json = JsonConvert.SerializeObject(@event);
            var bytes = Encoding.UTF8.GetBytes(json);
            
            _chanel.BasicPublish(Exchange, @event.GetType().Name, null, bytes);
        }
    }
}
