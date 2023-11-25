using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SteamEngine
{
	public class Sprite2D : Core2D
	{
        public Texture2D Texture;
        public Color Color = Color.White;
        public Sprite2D()
		{
            Size.X = Texture.Width;
            Size.Y = Texture.Height;
            SetMiddlePosition();
		}
        public Sprite2D(Texture2D texture)
		{
            Texture = texture;
            Size.X = Texture.Width;
            Size.Y = Texture.Height;
            SetMiddlePosition();
		}
        public Sprite2D(Texture2D texture, Color color)
		{
            Texture = texture;
            Color = color;
            Size.X = Texture.Width;
            Size.Y = Texture.Height;
            SetMiddlePosition();
		}
        public Sprite2D(Color color)
		{
            Color = color;
            Size.X = Texture.Width;
            Size.Y = Texture.Height;
            SetMiddlePosition();
		}
		public override void Update(GameTime gameTime)
		{

		}
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			if(Texture != null){
                spriteBatch.Draw(Texture, new Vector2(Position.X, Position.Y), Color);
            }
		}
	}
}