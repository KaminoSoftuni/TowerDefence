
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class IceBolt : Projectile
    {
        private const int IceBoltSpeed = 6;
        private const int IceBoltDamage = 5;
        private const ProjectileTypes Type = ProjectileTypes.FreezeProjectile;

        public IceBolt(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target)
            : base(coordinates, visualization, exists, IceBoltDamage, IceBoltSpeed, target, Type)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
