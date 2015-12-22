

namespace KaminoTD.GameObjects
{
    using System;
    using Enumerations;
    using Microsoft.Xna.Framework.Graphics;
    using KaminoTD.Interfaces;
    using Microsoft.Xna.Framework;
    using TowerDefence.GameObjects;

    public abstract class Tower : GameObject, ITower
    {
        private int levelDefault = 1;
        private IEnemy target;
        private int price;
        private int frameCount = 0;
        private int range;
        private int speed;
        private IProjectile projectile;

        protected Tower(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target,
            int price, TowerTypes type, int speed, IProjectile projectile, int range)
            : base(coordinates, visualization, exists)

        {
            this.Target = target;
            this.Price = price;
            this.Level = this.levelDefault;
            this.Type = type;
            this.Speed = speed;
            this.Projectile = projectile;
            this.Range = range;
        }

        public int Level { get; protected set; }

        public TowerTypes Type { get; protected set; }

        public int Range
        {
            get
            {
                return this.range;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Range cannot be negative or zero");
                }
                this.range = value;
            }
        }

        public IEnemy Target
        {
            get
            {
                return this.target;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Target cannot be null");
                }

                this.target = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative or zero");
                }

                this.price = value;
            }
        }

        public IProjectile Projectile
        {
            get
            {
                return this.projectile;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Projectile cannot be null");
                }

                this.projectile = value;
            }
        }
      
        public int Speed
        {
            get
            {
                return this.speed;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Speed cannot be negative or zero");
                }

                this.speed = value;
            }
        }

        public IProjectile FireProjectile()
        {
            throw new NotImplementedException();
        }

        public void Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}
