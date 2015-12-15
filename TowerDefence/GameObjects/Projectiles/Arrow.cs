
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Geometry;
    using Interfaces;

    public class Arrow : Projectile
    {
        public Arrow(Point coordinates, int damage, int speed, IEnemy target) 
            : base(coordinates, damage, speed, target)
        {
        }
    }
}
