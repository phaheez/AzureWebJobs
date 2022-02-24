using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QueueProcessor
{
    public class Functions
    {
        // runs every 1 minute and on startup
        public async Task MyTimerTriggerOperation([TimerTrigger("0 */1 * * * *", RunOnStartup = true)] TimerInfo timerInfo, ILogger logger, CancellationToken cancellationToken)
        {
            // To some work...
            await Task.Delay(100, cancellationToken);

            logger.LogInformation("[success]: Runs every 1 minute and on startup");
        }

        //public static void ProcessQueueMessage([QueueTrigger("webjobqueue")] string message, ILogger logger)
        //{
        //    logger.LogInformation(message);
        //}
    }
}
