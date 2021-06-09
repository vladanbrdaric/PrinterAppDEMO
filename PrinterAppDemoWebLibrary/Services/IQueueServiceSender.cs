using System.Threading.Tasks;

namespace PrinterAppDemoWebLibrary.Services
{
    public interface IQueueServiceSender
    {
        Task SendMessageAsync<T>(T serviceBusMessage, string queueName);
    }
}