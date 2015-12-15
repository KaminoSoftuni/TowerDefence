
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Geometry;
    using Interfaces;

    public class PoisonArrow : Projectile
    {
        public PoisonArrow(Point coordinates, int damage, int speed, IEnemy target)
            : base(coordinates, damage, speed, target)
        {
        }
    }
}
