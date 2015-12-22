
namespace KaminoTD.GameObjects.Enemies
{
    using Microsoft.Xna.Framework.Graphics;

    public class AlienEnemy : Enemy
    {
        private const int health = 50;
        
        
        public AlienEnemy(Texture2D enemy , CastleTower castle)
            : base(enemy , health, castle)
        {
            
        }
    }
}
