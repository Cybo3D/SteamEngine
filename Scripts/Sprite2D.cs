using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SteamEngine
{
	public class Sprite2D : Core2D
	{
        public Texture2D Texture;
        public Color Color = Color.White;

        // Frame information
        public int HFrames = 1;
        public int VFrames = 1;
        public int CurrentFrame = 0;
        int frameWidth;
        int frameHeight;
        public Sprite2D(Texture2D texture)
        {
            // Initialize other properties here
            Texture = texture;
            frameWidth = Texture.Width;
            frameHeight = Texture.Height;
            LocalSize.X = frameWidth;
            LocalSize.Y = frameHeight;
        }
        public Sprite2D(Texture2D texture, Color color)
        {
            // Initialize other properties here
            Texture = texture;
            Color = color;
            frameWidth = Texture.Width;
            frameHeight = Texture.Height;
            LocalSize.X = frameWidth;
            LocalSize.Y = frameHeight;
        }
        public Sprite2D(Texture2D texture, Color color, int HFrames, int VFrames)
        {
            // Initialize other properties here
            Texture = texture;
            Color = color;
            frameWidth = Texture.Width / HFrames;
            frameHeight = Texture.Height / VFrames;
            LocalSize.X = frameWidth;
            LocalSize.Y = frameHeight;
        }
        public Sprite2D(Texture2D texture, int HFrames, int VFrames)
        {
            // Initialize other properties here
            Texture = texture;
            frameWidth = Texture.Width / HFrames;
            frameHeight = Texture.Height / VFrames;
            LocalSize.X = frameWidth;
            LocalSize.Y = frameHeight;
        }

        public override void Update(GameTime gameTime)
        {
            // Add frame update logic if needed
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (Texture != null)
            {

                // Calculate source rectangle for the current frame
                Rectangle sourceRectangle = new Rectangle(
                    frameWidth * (CurrentFrame % HFrames),
                    frameHeight * (CurrentFrame / HFrames),
                    frameWidth,
                    frameHeight
                );
                Rectangle rectangle = new(
                    (int)GlobalPosition.X,
                    (int)GlobalPosition.Y,
                    (int)LocalSize.X,
                    (int)LocalSize.Y
                );
                // Draw the current frame
                spriteBatch.Draw(Texture,
                                rectangle,
                                sourceRectangle, 
                                Color, 
                                MathHelper.ToRadians(GlobalRotation), 
                                new Vector2(GlobalMiddlePosition.X, GlobalMiddlePosition.Z), 
                                new SpriteEffects(), 
                                GlobalPosition.Z);
            }
        }
	}
}