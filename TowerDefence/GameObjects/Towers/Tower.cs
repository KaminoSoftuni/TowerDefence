

namespace KaminoTD.GameObjects
{
    using System;
    using Microsoft.Xna.Framework.Graphics;
    using KaminoTD.Interfaces;
    using Geometry;

    public abstract class Tower : ITower
    {
        private int range;

        public Tower(int range)
        {
            this.Range = range;
        }

        public int Range
        {
            get { return this.range; }
            set { this.range = value; }
        }

        public IEnemy Target { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }
        public IProjectile FireProjectile()
        {
            throw new NotImplementedException();
        }

        public void Upgrade()
        {
            throw new NotImplementedException();
        }

        public abstract void Draw(SpriteBatch spriteBatch);
        public int Speed { get; set; }

        public Point Coordinates
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
