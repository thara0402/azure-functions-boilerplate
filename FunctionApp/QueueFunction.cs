using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp
{
    public class QueueFunction
    {
        [FunctionName(nameof(QueueFunction))]
        public void Run([QueueTrigger("myqueue-items", Connection = "StorageBindingConnection")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
