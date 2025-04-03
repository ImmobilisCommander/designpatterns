using Microsoft.Extensions.Logging;

using Polly;
using Polly.Bulkhead;

using System.Threading.Tasks.Dataflow;

namespace Julien.Pattern.BulkHead
{
    internal class AnyKindOfService : IAnyKindOfService
    {
        private readonly ILogger<AnyKindOfService> logger;
        private const int maxDegreeOfParallelism = 5;
        private const int maxNumberOfTasks = 10;
        private readonly TimeSpan delay = TimeSpan.FromSeconds(3);

        public AnyKindOfService(ILogger<AnyKindOfService> logger)
        {
            this.logger = logger;
        }

        public async Task<int> DoWorkWithActionBlockAsync()
        {
            int result = 0;

            // Crée un compartiment (bulkhead) avec une limite d'exécutions simultanées
            var bulkhead = new ActionBlock<int>(async request =>
            {
                // Simule un traitement
                await Task.Delay(delay);
                logger.LogInformation("Traitement de la requête {request}", request);
                Interlocked.Increment(ref result);

            }, new ExecutionDataflowBlockOptions { MaxDegreeOfParallelism = maxDegreeOfParallelism });

            // Envoie 10 requêtes simultanées
            for (int i = 0; i < maxNumberOfTasks; i++)
            {
                await bulkhead.SendAsync(i);
            }

            // Attend la fin du traitement
            bulkhead.Complete();

            await bulkhead.Completion;

            return result;
        }

        public async Task<int> DoWorkWithFunctAsync()
        {
            int result = 0;

            SemaphoreSlim semaphore = new(maxDegreeOfParallelism, maxDegreeOfParallelism);

            // Crée un compartiment (bulkhead) avec une limite de 5 exécutions simultanées
            var bulkhead = new Func<int, Task>(async request =>
            {
                await semaphore.WaitAsync();
                try
                {
                    // Simule un traitement
                    await Task.Delay(delay);
                    logger.LogInformation("Traitement de la requête {request}", request);
                    Interlocked.Increment(ref result);
                }
                finally
                {
                    semaphore.Release();
                }
            });

            List<Task> tasks = [];

            for (int i = 0; i < maxNumberOfTasks; i++)
            {
                tasks.Add(bulkhead.Invoke(i));
            }

            await Task.WhenAll(tasks);

            return result;
        }

        public async Task<int> DoWorkWithPollyAsync()
        {
            int result = 0;

            AsyncBulkheadPolicy bulkheadPolicy = Policy.BulkheadAsync(maxDegreeOfParallelism, 6, (context) =>
            {
                logger.LogWarning("Rejected call {index}...", (int)context["index"]);
                return Task.CompletedTask;
            });

            List<Task> tasks = [];

            for (int i = 0; i < maxNumberOfTasks; i++)
            {
                IDictionary<string, object> data = new Dictionary<string, object>() { { "index", i } };

                tasks.Add(bulkheadPolicy.ExecuteAsync(async (context) =>
                {
                    // Simule un traitement
                    await Task.Delay(delay);
                    logger.LogInformation("Traitement de la requête {request}", (int)context["index"]);

                    Interlocked.Increment(ref result);

                }, data));
            }

            await Task.WhenAll(tasks);

            return result;
        }
    }
}