
namespace KaminoTD.GameObjects.Towers
{
    using System;
    using Enumerations;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class FireTower : Tower, ITower
    {
        private const int FireTowerPrice = 50;
        private const TowerTypes Type = TowerTypes.Fire;
        private const int FireTowerSpeed = 8;
        private const int FireTowerRange = 100;

        public FireTower(Vector2 coordinates, Texture2D visualization, bool exists, IEnemy target, IProjectile projectile)
            : base(coordinates, visualization, exists, target, FireTowerPrice, Type, FireTowerSpeed, projectile, FireTowerRange)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
