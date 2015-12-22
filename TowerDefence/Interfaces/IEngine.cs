
using Microsoft.Xna.Framework.Graphics;

namespace KaminoTD.Interfaces
{
    using System.Collections.Generic;
    using GameObjects;
    using GameObjects.Enemies;

    public interface IEngine
    {
        void TakeEnemyInRange(IList<Enemy> enemys);

        void CheckBaseHealth(CastleTower baseTower, Texture2D gameOver);

        // void Start();
        // 
        // void Stop();
    }
}
