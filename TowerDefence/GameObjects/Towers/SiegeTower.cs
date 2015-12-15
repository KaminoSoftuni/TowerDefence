
namespace KaminoTD.GameObjects.Towers
{
    using System;
    using Interfaces;
    using Microsoft.Xna.Framework.Graphics;

    public class SiegeTower : Tower, ITower
    {
        public SiegeTower(int range) 
            : base(range)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
