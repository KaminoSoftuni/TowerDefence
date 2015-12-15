using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefence.Interfaces;

namespace KaminoTD.GameObjects
{
    using Interfaces;

    public class CastleTower : ICastle
    {
 
        private Texture2D tower;
        private int health = 5;

        public CastleTower(Texture2D tower)
        {

            this.Tower = tower;

        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public void RemoveHealth()
        {
            this.Health--;
        }


       

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tower, new Vector2(588, 64), Color.White);

        }

        public Texture2D Tower
        {
            get { return this.tower; }
            set { this.tower = value; }
        }
    }
}
