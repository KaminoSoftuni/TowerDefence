
namespace KaminoTD.GameObjects.Towers
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class SiegeTower : Tower, ITower
    {
        private const int SiegeTowerPrice = 50;
        private const TowerTypes Type = TowerTypes.Splash;
        private const int SiegeTowerSpeed = 8;
        private const int SiegeTowerRange = 100;

        public SiegeTower(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target, IProjectile projectile)
            : base(coordinates, visualization, exists, target, SiegeTowerPrice, Type, SiegeTowerSpeed, projectile, SiegeTowerRange)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
