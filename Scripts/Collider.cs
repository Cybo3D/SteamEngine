using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RolePlayingGame.Collisions
{
    public class Collision
    {
        private Rectangle _collisionRectangle;
        public Rectangle CollisionRectangle
        {
            get { return _collisionRectangle; }
            set { _collisionRectangle = value; }
        }

        public Collision(Texture2D texture, Vector2 position)
        {
            // Initialize the collision rectangle in the constructor
            _collisionRectangle = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }

        public bool IsTouchingTop(Collision other)
        {
            return this._collisionRectangle.Bottom >= other._collisionRectangle.Top &&
                   this._collisionRectangle.Top < other._collisionRectangle.Top &&
                   this._collisionRectangle.Right > other._collisionRectangle.Left &&
                   this._collisionRectangle.Left < other._collisionRectangle.Right;
        }

        public bool IsTouchingBottom(Collision other)
        {
            return this._collisionRectangle.Top <= other._collisionRectangle.Bottom &&
                   this._collisionRectangle.Bottom > other._collisionRectangle.Bottom &&
                   this._collisionRectangle.Right > other._collisionRectangle.Left &&
                   this._collisionRectangle.Left < other._collisionRectangle.Right;
        }

        public bool IsTouchingLeft(Collision other)
        {
            return this._collisionRectangle.Right >= other._collisionRectangle.Left &&
                   this._collisionRectangle.Left < other._collisionRectangle.Left &&
                   this._collisionRectangle.Bottom > other._collisionRectangle.Top &&
                   this._collisionRectangle.Top < other._collisionRectangle.Bottom;
        }

        public bool IsTouchingRight(Collision other)
        {
            return this._collisionRectangle.Left <= other._collisionRectangle.Right &&
                   this._collisionRectangle.Right > other._collisionRectangle.Right &&
                   this._collisionRectangle.Bottom > other._collisionRectangle.Top &&
                   this._collisionRectangle.Top < other._collisionRectangle.Bottom;
        }

    }
}