namespace Julien.Pattern.Bridge
{

    // Classe concrète pour les cercles
    public class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, IDrawAPI drawAPI) 
            : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawAPI.DrawCircle(x, y, radius);
        }
    }
}