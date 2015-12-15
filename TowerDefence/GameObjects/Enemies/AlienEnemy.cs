using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace KaminoTD.GameObjects.Enemies
{
    public class AlienEnemy : Enemy
    {
        private const int health = 6;
        
        public AlienEnemy(Texture2D enemy) : base(enemy , health)
        {
            
        }

        
    }
}
