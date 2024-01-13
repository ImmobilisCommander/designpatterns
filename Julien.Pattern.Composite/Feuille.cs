namespace Julien.Pattern.Composite
{
    using Microsoft.Extensions.Logging;

    // Feuille
    public class Feuille : Composant
    {
        private readonly ILogger<Feuille> logger;

        public Feuille(ILogger<Feuille> logger)
        {
            this.logger = logger;
        }

        public override void Operation()
        {
            logger.LogInformation("Opération de la feuille");
        }
    }
}
