
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class CannonBall : Projectile, IProjectile
    {
        private const int CannonBallSpeed = 8;
        private const int CannonBallDamage = 6;
        private const ProjectileTypes Type = ProjectileTypes.SplashProjectile;

        public CannonBall(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target)
            : base(coordinates, visualization, exists, CannonBallDamage, CannonBallSpeed, target, Type)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
