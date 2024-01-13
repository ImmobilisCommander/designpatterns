using Microsoft.Extensions.Logging;

namespace Julien.Pattern.Command
{
    // Le Receiver
    internal class Light
    {
        private readonly ILogger<Light> logger;

        public Light(ILogger<Light> logger)
        {
            this.logger = logger;
        }

        public void TurnOn()
        {
            logger.LogInformation("Light is turned on");
        }

        public void TurnOff()
        {
            logger.LogInformation("Light is turned off");
        }
    }
}