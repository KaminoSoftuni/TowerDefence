
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Geometry;
    using Interfaces;

    public abstract class Projectile : IProjectile
    {
        protected Projectile(Point coordinates, int damage, int speed, IEnemy target)
        {
            this.Coordinates = coordinates;
            this.Damage = damage;
            this.Speed = speed;
            this.Target = target;
        }

        public Point Coordinates { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public IEnemy Target { get; set; }
    }
}
