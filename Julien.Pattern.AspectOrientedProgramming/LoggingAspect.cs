using Castle.DynamicProxy;

using Microsoft.Extensions.Logging;

using Serilog;

namespace Julien.Pattern.AspectOrientedProgramming
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class LoggingAspect : Attribute, IInterceptor
    {
        private readonly Microsoft.Extensions.Logging.ILogger logger;

        public LoggingAspect(Type type)
        {
            var f = LoggerFactory.Create(o =>
            {
                o.AddSerilog();
            });

            this.logger = f.CreateLogger(type);
        }

        public void Intercept(IInvocation invocation)
        {
            // On effectue des opérations avant l'exécution de la méthode
            logger.LogInformation("Avant l'appel de la méthode...");
            // On appelle la méthode interceptée
            invocation.Proceed();
            // On effectue des opérations après l'exécution de la méthode
            logger.LogInformation("Après l'appel de la méthode...");
        }
    }
}