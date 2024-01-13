namespace Julien.Pattern.Bridge
{
    using Microsoft.Extensions.Logging;

    // Implémentations de l'interface de dessin
    public class DrawCircleWithPen : IDrawAPI
    {
        private readonly ILogger<DrawCircleWithPen> logger;

        public DrawCircleWithPen(ILogger<DrawCircleWithPen> logger)
        {
            this.logger = logger;
        }

        public void DrawCircle(int x, int y, int radius)
        {
            logger.LogInformation($"Drawing Circle [Pen] at ({x}, {y}), radius {radius}");
        }
    }

}