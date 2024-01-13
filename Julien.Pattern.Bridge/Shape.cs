namespace Julien.Pattern.Bridge
{
    // Classe abstraite pour les formes géométriques
    public abstract class Shape
    {
        protected IDrawAPI drawAPI;

        protected Shape(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}