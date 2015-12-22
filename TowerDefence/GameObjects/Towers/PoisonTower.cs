
namespace KaminoTD.GameObjects.Towers
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class PoisonTower : Tower, ITower
    {
        private const int PoisonTowerPrice = 50;
        private const TowerTypes Type = TowerTypes.Poison;
        private const int PoisonTowerSpeed = 8;
        private const int PoisonTowerRange = 100;

        public PoisonTower(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target, IProjectile projectile)
            : base(coordinates, visualization, exists, target, PoisonTowerPrice, Type, PoisonTowerSpeed, projectile, PoisonTowerRange)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
