using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrinterAppDemoWebLibrary.Services
{
    public class QueueServiceSender : IQueueServiceSender
    {
        // To be able to access 'appsettings.json'.
        private readonly IConfiguration _config;

        public QueueServiceSender(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendMessageAsync<T>(T serviceBusMessage, string queueName)
        {
            try
            {
                // Creating (establishing) the connection with the queue
                var queueClient = new QueueClient(_config.GetConnectionString("AzureServiceBus"), queueName);

                // Convert object into string.
                string messageBody = JsonSerializer.Serialize(serviceBusMessage);

                // Convert string into bytes.
                var message = new Message(Encoding.UTF8.GetBytes(messageBody));

                // Send a message to the service bus.
                await queueClient.SendAsync(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
