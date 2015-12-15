
namespace KaminoTD.GameObjects.Towers
{
    using System;
    using Interfaces;
    using Microsoft.Xna.Framework.Graphics;

    public class PoisonTower : Tower, ITower
    {
        public PoisonTower(int range)
            : base(range)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
