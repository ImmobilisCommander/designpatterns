namespace Julien.Pattern.Composite
{
    using Microsoft.Extensions.Logging;

    using System.Collections.Generic;

    // Composite
    public class Composite : Composant
    {
        private readonly List<Composant> enfants = [];
        private readonly ILogger<Composite> logger;

        public Composite(ILogger<Composite> logger)
        {
            this.logger = logger;
        }

        public void AjouterEnfant(Composant enfant)
        {
            enfants.Add(enfant);
        }

        public void SupprimerEnfant(Composant enfant)
        {
            enfants.Remove(enfant);
        }

        public override void Operation()
        {
            logger.LogInformation("Opération du composite");
            foreach (var enfant in enfants)
            {
                enfant.Operation();
            }
        }
    }
}
