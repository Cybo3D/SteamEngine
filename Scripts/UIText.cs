using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SteamEngine.UI
{
    public class UIText : CoreUI
    {
        // only one limitation, font files need to be only width no height
        public string[] letters = {
            "A",
            "B",
            "C",
            "D",
            "E",
        };
        public Texture2D Texture;
        public Color Color = Color.White;

        public string Text;

        // Frame information
        public int HFrames = 1;
        public int VFrames = 1;
        public int CurrentFrame = 0;
        int letterWidth;
        int letterHeight;
        public UIText(string text, Texture2D texture, Color color, int LettersInWidth)
        {
            // Initialize other properties here
            Text = text;
            Texture = texture;
            Color = color;
            letterWidth = Texture.Width / LettersInWidth;
            letterHeight = Texture.Height;
            LocalSize.X = letterWidth;
            LocalSize.Y = letterHeight;
        }
        public UIText(string text, Texture2D texture, int LettersInWidth)
        {
            // Initialize other properties here
            Text = text;
            Texture = texture;
            letterWidth = Texture.Width / LettersInWidth;
            letterHeight = Texture.Height;
            LocalSize.X = letterWidth;
            LocalSize.Y = letterHeight;
        }

        public override void Update(GameTime gameTime)
        {
            // Add frame update logic if needed
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (Texture != null)
            {
                if (Text == null) return;
                int index = 0;
                //Console.WriteLine("text: " + Text);
                foreach (char letter in Text)
                {
                    //Console.WriteLine("index: " + index);
                    CurrentFrame = Array.IndexOf(letters, letter.ToString());
                    //Console.WriteLine("frame: " + CurrentFrame);
                    Console.WriteLine("width: " + letterWidth);
                    // Calculate source rectangle for the current frame
                    Rectangle sourceRectangle = new Rectangle(
                        letterWidth * CurrentFrame,
                        0,
                        letterWidth,
                        letterHeight
                    );
                    Rectangle rectangle = new(
                        (int)GlobalPosition.X + index * letterWidth,
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
                    index++;
                }
            }
        }
    }
}