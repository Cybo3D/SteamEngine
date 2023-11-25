using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SteamEngine.Camera;

using SteamEngine.Input;

namespace SteamEngine;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    WaterInput input = new WaterInput();
    Sprite2D sprite;
    WoodCamera woodCamera = new WoodCamera();
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

        sprite = new Sprite2D(Content.Load<Texture2D>("SpaceShip"), 3, 3){
            Rotation = 90
        };
        sprite.SetMiddlePosition();
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (input.ButtonPressed("Exit"))
            Exit();

        // TODO: Add your update logic here
        input.Update();
        woodCamera.Follow(sprite, new Vector2(648,648));
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        
        _spriteBatch.Begin(transformMatrix: woodCamera.Matrix);
        // TODO: Add your drawing code here
        sprite.Draw(gameTime, _spriteBatch);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
