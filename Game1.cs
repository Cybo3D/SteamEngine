using System;
using System.Collections.Generic;
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
    Cluster player;
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
        player = new Cluster(new List<Core2D>{
            new Sprite2D(Content.Load<Texture2D>("SpaceShip")){
                LocalPosition = new Vector3(10, 0 ,0)
            },
            new Sprite2D(Content.Load<Texture2D>("SpaceShip")){
                LocalPosition = new Vector3(0, 0 ,0)
            }
        });
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
        player.Draw(gameTime, _spriteBatch);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
