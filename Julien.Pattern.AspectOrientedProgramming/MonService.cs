using Microsoft.Extensions.Logging;

namespace Julien.Pattern.AspectOrientedProgramming
{
    // On crée une classe pour notre service
    public class MonService : IMonService
    {
        private readonly ILogger<MonService> logger;

        public MonService(ILogger<MonService> logger)
        {
            this.logger = logger;
        }

        [LoggingAspect(typeof(MonService))]
        public void MaMethode()
        {
            logger.LogInformation("Exécution de MaMethode...");
        }
    }
}