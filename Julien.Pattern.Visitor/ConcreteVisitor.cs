namespace Julien.Pattern.Visitor
{
    using Microsoft.Extensions.Logging;

    internal class ConcreteVisitor : IVisitor
    {
        private readonly ILogger<ConcreteVisitor> logger;

        public ConcreteVisitor(ILogger<ConcreteVisitor> logger)
        {
            this.logger = logger;
        }

        public void Visit(IVisitable visitable)
        {
            if (visitable is ConcreteVisitable concreteVisitable)
            {
                logger.LogInformation("Je visite un objet ConcreteVisitable avec la propriété {0}", concreteVisitable.Property);
            }
        }
    }
}