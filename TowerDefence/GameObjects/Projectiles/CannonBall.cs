
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Geometry;
    using Interfaces;

    public class CannonBall : Projectile
    {
        public CannonBall(Point coordinates, int damage, int speed, IEnemy target)
            : base(coordinates, damage, speed, target)
        {
        }
    }
}
