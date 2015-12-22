

namespace KaminoTD.GameObjects
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using TowerDefence.GameObjects;
    using TowerDefence.Interfaces;

    public class CastleTower : GameObject, ICastle
    {
        private Texture2D tower;
        private int health = 20;
        private static Vector2 position;
        private int xPosition = 588;
        private int yPosition = 64;

        public CastleTower(Texture2D tower) : base(position, tower, true)
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
        public Texture2D Tower
        {
            get
            {
                return this.tower;
            }
            set
            {
                this.tower = value;
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tower, new Vector2(588, 64), Color.White);

        }

        public static bool IsOnCastle(int y, int x, int buffer)
        {
            if ((x >= 585 + buffer / 2 && x <= 658 + buffer)
                && (y > 10 + buffer && y < 130 + buffer))
            {
                return true;
            }
            return false;
        }
    }
}
