using Microsoft.Xna.Framework;

namespace SteamEngine.Camera
{
    public class WoodCamera
    {
        public Matrix Transform { get; private set; }

        public void Follow(Player target, Vector2 ScreenSize)
        {
            
            var position = Matrix.CreateTranslation(
              -target.Position.X - (target.Rectangle.Width / 2),
              -target.Position.Y - (target.Rectangle.Height / 2),
              0);

            var offset = Matrix.CreateTranslation(
                ScreenSize.X / 2,
                ScreenSize.Y / 2,
                0);

            Transform = position * offset;
        }
    }
}