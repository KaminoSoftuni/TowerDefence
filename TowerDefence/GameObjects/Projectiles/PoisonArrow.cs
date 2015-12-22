
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class PoisonArrow : Projectile
    {
        private const int PoisonArrowSpeed = 10;
        private const int PoisonArrowDamage = 4;
        private const ProjectileTypes Type = ProjectileTypes.PoisonProjectile;

        public PoisonArrow(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target)
            : base(coordinates, visualization, exists, PoisonArrowDamage, PoisonArrowSpeed, target, Type)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
