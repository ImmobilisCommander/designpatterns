namespace Julien.Pattern.Bridge
{
    using Microsoft.Extensions.Logging;

    public class DrawCircleWithBrush : IDrawAPI
    {
        private readonly ILogger<DrawCircleWithBrush> logger;

        public DrawCircleWithBrush(ILogger<DrawCircleWithBrush> logger)
        {
            this.logger = logger;
        }

        public void DrawCircle(int x, int y, int radius)
        {
            logger.LogInformation($"Drawing Circle [Brush] at ({x}, {y}), radius {radius}");
        }
    }

}