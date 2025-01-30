namespace Julien.Pattern.Tests
{
    using Julien.Pattern.Composite;

    using Microsoft.Extensions.Logging;

    using NSubstitute;

    public class CompositeTests : IClassFixture<TestsFixture>
    {
        private readonly TestsFixture fixture;

        public CompositeTests(TestsFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void CopositeTest()
        {
            var logger1 = Substitute.For<ILogger<Composite>>();
            var logger2 = Substitute.For<ILogger<Composite>>();
            var logger3 = Substitute.For<ILogger<Feuille>>();
            var logger4 = Substitute.For<ILogger<Feuille>>();
            var logger5 = Substitute.For<ILogger<Feuille>>();
            var logger6 = Substitute.For<ILogger<Feuille>>();

            Composite composite = new(logger1);
            composite.AjouterEnfant(new Feuille(logger3));
            composite.AjouterEnfant(new Feuille(logger4));

            Composite composite2 = new(logger2);
            composite2.AjouterEnfant(new Feuille(logger5));
            composite2.AjouterEnfant(new Feuille(logger6));

            composite.AjouterEnfant(composite2);

            // Appel de l'opération sur le composite
            composite.Operation();

            logger1.Received().LogInformation("Opération du composite");
            logger2.Received().LogInformation("Opération du composite");
            logger3.Received().LogInformation("Opération de la feuille");
            logger4.Received().LogInformation("Opération de la feuille");
            logger5.Received().LogInformation("Opération de la feuille");
            logger6.Received().LogInformation("Opération de la feuille");
        }
    }
}