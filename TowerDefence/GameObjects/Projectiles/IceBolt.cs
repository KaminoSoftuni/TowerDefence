
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Geometry;
    using Interfaces;

    public class IceBolt : Projectile
    {
        public IceBolt(Point coordinates, int damage, int speed, IEnemy target) 
            : base(coordinates, damage, speed, target)
        {
        }
    }
}
