using Julien.Pattern.Visitor;

using Microsoft.Extensions.DependencyInjection;

namespace Julien.Pattern.Tests
{
    public class VisitorTests : IClassFixture<TestsFixture>
    {
        private readonly TestsFixture context;

        public VisitorTests(TestsFixture context)
        {
            this.context = context;
        }
        
        [Fact]
        public void VisitorTest()
        {
            // Créer un objet visitable
            var visitable = context.ServiceProvider.GetRequiredService<IVisitable>();

            // Créer un visiteur
            var visitor = context.ServiceProvider.GetRequiredService<IVisitor>();

            // Faire accepter le visiteur par l'objet visitable
            visitable.Accept(visitor);
        }
    }
}