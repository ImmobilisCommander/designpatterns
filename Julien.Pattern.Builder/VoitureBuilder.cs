namespace Julien.Pattern.Builder
{
    public class VoitureBuilder
    {
        private Voiture voiture = new();

        public VoitureBuilder SetMarque(string marque)
        {
            voiture.Marque = marque;
            return this;
        }

        public VoitureBuilder SetModele(string modele)
        {
            voiture.Modele = modele;
            return this;
        }

        public VoitureBuilder SetCouleur(string couleur)
        {
            voiture.Couleur = couleur;
            return this;
        }

        public VoitureBuilder SetAnnee(int annee)
        {
            voiture.Annee = annee;
            return this;
        }

        public VoitureBuilder SetGPS(bool gps)
        {
            voiture.GPS = gps;
            return this;
        }

        public VoitureBuilder SetSiegesCuir(bool siegesCuir)
        {
            voiture.SiegesCuir = siegesCuir;
            return this;
        }

        public Voiture Build()
        {
            return voiture;
        }
    }

}