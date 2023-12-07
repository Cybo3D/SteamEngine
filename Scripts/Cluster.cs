using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SteamEngine
{
    public class Cluster : Core2D{
        public List<Core2D> Cores;
        public Cluster(List<Core2D> clusters){
            Cores = clusters;
            foreach(var Core in Cores){
                //Core.Update(gameTime);

                if(Core == Cores[0]){
                    Core.GlobalPosition = Core.LocalPosition;
                    Core.GlobalRotation = Core.LocalRotation;
                    Core.GlobalSize = Core.LocalSize;
                }

                Core.GlobalPosition = Cores[0].LocalPosition + Core.LocalPosition;
                Core.GlobalRotation += Cores[0].LocalRotation + Core.LocalRotation;
                Core.GlobalSize += Cores[0].LocalSize + Core.LocalSize;
            }
        }
        public override void Update(GameTime gameTime)
		{
            foreach(var Core in Cores){
                Core.Update(gameTime);

                if(Core == Cores[0]){
                    Core.GlobalPosition = Core.LocalPosition;
                    Core.GlobalRotation = Core.LocalRotation;
                    Core.GlobalSize = Core.LocalSize;

                    Console.WriteLine(GlobalPosition);
                }

                Core.GlobalPosition = Cores[0].LocalPosition + Core.LocalPosition;
                Core.GlobalRotation += Cores[0].LocalRotation + Core.LocalRotation;
                Core.GlobalSize += Cores[0].LocalSize + Core.LocalSize;
            }
		}
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			foreach(var Core in Cores){
                Core.Draw(gameTime, spriteBatch);
            }
		}
    }
}