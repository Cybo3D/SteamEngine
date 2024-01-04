using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using SteamEngine.Camera;
using SteamEngine.Input;
using SteamEngine.UI;

namespace SteamEngine;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    WaterInput input = new WaterInput();
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        _graphics.PreferredBackBufferWidth = 648;
        _graphics.PreferredBackBufferHeight = 648;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (input.ButtonPressed("Exit"))
            Exit();

        // TODO: Add your update logic here
        input.Update();
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        
        _spriteBatch.Begin();
        // TODO: Add your drawing code here
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
