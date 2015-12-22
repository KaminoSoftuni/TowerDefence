
namespace TowerDefence.GameObjects
{
    using System;

    using KaminoTD.Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class GameObject : IGameObject
    {
        protected GameObject(Vector2 coordinates, Texture2D visualization, bool exists)
        {
            this.Coordinates = coordinates;
            this.Visualization = visualization;
            this.Exists = exists;
        }

        public Vector2 Coordinates { get;  set; }

        public Texture2D Visualization { get; private set; }

        public bool Exists { get; protected set; }

        public abstract void Draw(SpriteBatch spriteBatch);

    }
}
