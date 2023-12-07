using Microsoft.Xna.Framework;

namespace SteamEngine.Camera
{
    public class WoodCamera
    {
        public Matrix Matrix { get; private set; }

        public void Follow(Core2D target, Vector2 ScreenSize)
        {
            var position = Matrix.CreateTranslation(
              -target.GlobalMiddlePosition.X,
              -target.GlobalMiddlePosition.Y,
              0);

            var offset = Matrix.CreateTranslation(
                ScreenSize.X / 2,
                ScreenSize.Y / 2,
                0);

            Matrix = position * offset;
        }
    }
}