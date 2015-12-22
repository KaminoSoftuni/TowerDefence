
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using TowerDefence.GameObjects;

    public abstract class Projectile : GameObject, IProjectile
    {
        private int speed;
        private IEnemy target;
        private int damage;

        protected Projectile(Vector2 coordinates, Texture2D visualization, bool exists, int damage, int speed, IEnemy target, ProjectileTypes type)
            : base(coordinates, visualization, exists)
        {
            this.Damage = damage;
            this.Speed = speed;
            this.Target = target;
            this.Type = type;
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The damage of the projectiles cannot be negative");
                }

                this.damage = value;
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
                if (value < 0)
                {
                    throw new ArgumentException("The speed cannot be a negative number.");
                }

                this.speed = value;
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
                    throw new ArgumentException("The target of the projectile cannot be null");
                }

                this.target = value;
            }
        }

        public ProjectileTypes Type { get; protected set; }
    }
}
