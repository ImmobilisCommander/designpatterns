using Julien.Pattern.Builder;

using Shouldly;

using Xunit.Abstractions;
using Xunit.Categories;

namespace Julien.Pattern.Tests
{
    [UnitTest]
    public class BuilderTests
    {
        [Fact]
        public void BuilderTest()
        {
            VoitureBuilder builder = new();

            // Créer une voiture avec des options de base
            Voiture voiture = builder
                .SetMarque("Toyota")
                .SetModele("Camry")
                .SetCouleur("Noir")
                .SetAnnee(2021)
                .Build();

            voiture.Annee.ShouldBe(2021);
            voiture.Couleur.ShouldBe("Noir");
            voiture.GPS.ShouldBeFalse();
            voiture.Marque.ShouldBe("Toyota");
            voiture.Modele.ShouldBe("Camry");
            voiture.SiegesCuir.ShouldBeFalse();

            // Créer une voiture avec des options supplémentaires
            voiture = builder
                .SetMarque("Mercedes-Benz")
                .SetModele("S-Class")
                .SetCouleur("Argent")
                .SetAnnee(2022)
                .SetGPS(true)
                .SetSiegesCuir(true)
                .Build();

            voiture.Annee.ShouldBe(2022);
            voiture.Couleur.ShouldBe("Argent");
            voiture.GPS.ShouldBeTrue();
            voiture.Marque.ShouldBe("Mercedes-Benz");
            voiture.Modele.ShouldBe("S-Class");
            voiture.SiegesCuir.ShouldBeTrue();
        }
    }
}