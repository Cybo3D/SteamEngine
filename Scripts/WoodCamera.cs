using Microsoft.Xna.Framework;
using SteamEngine;

namespace SteamEngine.Camera
{
    public class WoodCamera
    {
        public Matrix Matrix { get; private set; }

        public void Follow(Core2D target, Vector2 ScreenSize)
        {
            var position = Matrix.CreateTranslation(
              -target.Position.X - (target.Size.X / 2),
              -target.Position.Y - (target.Size.Y / 2),
              0);

            var offset = Matrix.CreateTranslation(
                ScreenSize.X / 2,
                ScreenSize.Y / 2,
                0);

            Matrix = position * offset;
        }
    }
}