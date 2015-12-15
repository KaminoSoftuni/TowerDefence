using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace KaminoTD.Interfaces
{
    public interface ITower : IGameObject
    {
        void Draw(SpriteBatch spriteBatch);

        int Speed { get; }

        int Range { get; }

        IEnemy Target { get; }

        int Price { get; }

        int Level { get; }

        int Damage { get; }

        IProjectile FireProjectile();

        void Upgrade();
    }
}
