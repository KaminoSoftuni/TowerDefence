
namespace KaminoTD.GameObjects.Projectiles
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class FireBall : Projectile
    {
        private const int FireBallSpeed = 6;
        private const int FireBallDamage = 5;
        private const ProjectileTypes Type = ProjectileTypes.FireProjectile;

        public FireBall(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target)
            : base(coordinates, visualization, exists, FireBallDamage, FireBallSpeed, target, Type)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
