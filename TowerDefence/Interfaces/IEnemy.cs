using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaminoTD.Interfaces
{
    public interface IEnemy : IGameObject
    {
        int LifePoints { get; }

        void Update(GameTime gameTime);

        void Draw(SpriteBatch spriteBatch);

        int Bounty { get; }

        bool IsAlive { get; }

        
    }
}
