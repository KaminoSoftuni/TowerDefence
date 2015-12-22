
namespace KaminoTD.GameObjects.Towers
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class FrostTower : Tower, ITower
    {
        private const int FrostTowerPrice = 50;
        private const TowerTypes Type = TowerTypes.Ice;
        private const int FrostTowerSpeed = 8;
        private const int FrosTowerRange = 100;

        public FrostTower(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target, IProjectile projectile)
            : base(coordinates, visualization, exists, target, FrostTowerPrice, Type, FrostTowerSpeed, projectile, FrosTowerRange)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
