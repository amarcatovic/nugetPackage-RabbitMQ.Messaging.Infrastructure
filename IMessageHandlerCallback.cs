using System.Threading.Tasks;

namespace RabbitMQ.Messaging.Infrastructure
{
    public interface IMessageHandlerCallback
    {
        Task<bool> HandleMessageAsync(string messageType, string message);
    }
}
