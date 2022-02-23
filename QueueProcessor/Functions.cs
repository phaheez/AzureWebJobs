using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProcessor
{
    public class Functions
    {
        public static void ProcessQueueMessage([QueueTrigger("webjobqueue")] string message, ILogger logger)
        {
            logger.LogInformation(message);
        }
    }
}
