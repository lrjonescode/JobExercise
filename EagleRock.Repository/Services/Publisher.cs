using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using RabbitMQ.Client;

namespace EagleRock.Repository.Services
{
    public class Publisher : IPublisher
    {
        private readonly IConnection connection;
        private readonly RabbitMQ.Client.IModel channel;

        public Publisher()
        {
            /*var factory = new ConnectionFactory { HostName = "localhost" };
            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            channel.QueueDeclare(queue: "EagleRock", durable: false, exclusive: false, autoDelete: false, arguments: null); */


        }
        /// <summary>
        /// Publishes the road flow rate to exterbal subscribers
        /// </summary>
        public void Publish(RoadFlowRate rate)
        {
 
        }
    }
}
 
