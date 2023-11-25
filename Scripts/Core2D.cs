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
        public Core2D(Vector3 position)
		{
			Position = position;
            middlePosition = Position / new Vector3(Size, Position.Z);
		}
        public Core2D(Vector3 position, Vector3 rotation)
		{
			Position = position;
            Rotation = rotation;
            middlePosition = Position / new Vector3(Size, Position.Z);
		}
		public Core2D(Vector3 position, Vector3 rotation, Vector2 size)
		{
			Position = position;
            Rotation = rotation;
            Size = size;
            middlePosition = Position / new Vector3(Size, Position.Z);
		}
		public override void Update(GameTime gameTime)
		{

		}
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			
		}
	}
}