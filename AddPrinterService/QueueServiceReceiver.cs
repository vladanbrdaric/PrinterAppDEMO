using AddPrinterServiceBus.Data;
using AddPrinterServiceBus.Models;
using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace AddPrinterServiceBus
{
    public class QueueServiceReceiver
    {
        // NOTE: Add your own connection string.
        const string connectionString = "Endpoint=sb://printerappservicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=";
        const string queueName = "printerqueue";
        QueueClient queueClient = new QueueClient(connectionString, queueName);
        SqliteData sqliteData = new SqliteData();


        //public async Task ReceiveMessageAsync(string _queueName)
        public async Task ReceiveMessageAsync()
        {
            // Options that will be passed in when the queue receives the message.
            var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                // Process one message at the time.
                MaxConcurrentCalls = 1,

                // Don't mark the message as 'complete' when received.
                AutoComplete = false
            };

            // RegisterMessageHandler is a method that accept messages. It will be caled when new message comes in. (Kind of event handler).
            queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);

            Console.ReadLine();

            // Close the connection with the queue.
            await queueClient.CloseAsync();
        }

        private async Task ProcessMessagesAsync(Message message, CancellationToken token)
        {
            // Convert message from bytes back to string.
            var jsonString = Encoding.UTF8.GetString(message.Body);

            // Convert string to object.
            PrinterBasicModel printer = JsonSerializer.Deserialize<PrinterBasicModel>(jsonString);

            // Store the created printer object into the database.
            sqliteData.InsertNewPrinter(printer);

            // Mark the message as completed. I have to do this manual because in options I said 'AutoComplete = false'.
            await queueClient.CompleteAsync(message.SystemProperties.LockToken);
        }


        // If something go wrong, this method will be triggered.
        private async Task ExceptionReceivedHandler(ExceptionReceivedEventArgs arg)
        {
            Console.WriteLine($"Message handler exception: { arg.Exception }");
            //return Task.CompletedTask;
        }
    }
}
