using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SteamEngine
{
  public abstract class Core
  {
    public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

    public abstract void Update(GameTime gameTime);
  }
}