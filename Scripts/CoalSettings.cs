using Microsoft.Xna.Framework;

namespace SteamEngine.Settings
{
    public class CoalSettings
    {
        public int screenWidth {get; set;}
        public int screenHeight {get; set;}
        private GraphicsDeviceManager _graphics;
        public CoalSettings(GraphicsDeviceManager graphicsDeviceManager)
		{
            _graphics = graphicsDeviceManager;
		}
        public void Update(GameTime gameTime)
		{
            _graphics.PreferredBackBufferWidth = screenWidth;
            _graphics.PreferredBackBufferHeight = screenHeight;
		}
    }
}