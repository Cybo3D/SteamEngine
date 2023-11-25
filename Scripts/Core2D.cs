using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SteamEngine
{
	public class Core2D : Core
	{
        public Vector3 Position;
        public Vector2 Size = new Vector2(1, 1);
        public Vector3 Rotation;
        public Vector3 middlePosition;
        public Core2D()
		{

		}
        public void SetMiddlePosition()
        {
            middlePosition = new Vector3(Position.X + Size.X / 2, Position.Y + Size.Y / 2, Position.Z);
        }

		public override void Update(GameTime gameTime)
		{

		}
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			
		}
	}
}