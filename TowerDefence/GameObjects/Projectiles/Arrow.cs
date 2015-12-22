
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Arrow : Projectile
    {
        private const int ArrowSpeed = 11;
        private const int ArrowDamage = 3;
        private const ProjectileTypes Type = ProjectileTypes.ArrowProjectile;

        public Arrow(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target)
            : base(coordinates, visualization, exists, ArrowDamage, ArrowSpeed, target, Type)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
