using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SteamEngine
{
	public class Core2D : Core
	{
        public Vector3 LocalPosition;
        public Vector3 GlobalPosition;
        public Vector2 LocalSize = new Vector2(1, 1);
        public Vector2 GlobalSize = new Vector2(1, 1);
        public float LocalRotation;
        public float GlobalRotation;
        public Vector3 LocalMiddlePosition;
        public Vector3 GlobalMiddlePosition;
        public Core2D()
		{

		}
        private void SetMiddlePosition()
        {
            LocalMiddlePosition = new Vector3(LocalPosition.X + LocalSize.X / 2, LocalPosition.Y + LocalSize.Y / 2, LocalPosition.Z);
            GlobalMiddlePosition = new Vector3(GlobalPosition.X + GlobalSize.X / 2, GlobalPosition.Y + GlobalSize.Y / 2, GlobalPosition.Z);
        }

		public override void Update(GameTime gameTime)
		{
            SetMiddlePosition();
		}
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			
		}
	}
}