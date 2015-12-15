using System;
using System.CodeDom;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaminoTD.GameObjects.Enemies
{
    public class EnemyOnMap
    {
        private readonly List<Enemy> enemy;

        private int count;
        private int check = 0;
        private int time = 0;
        private Texture2D enemyTexture2D;

        public EnemyOnMap(Texture2D enemy, int count)
        {
            this.Count = count;
            this.enemyTexture2D = enemy;
            this.enemy = new List<Enemy>();
        }

        public Texture2D EnemyTexture2D
        {
            get { return this.enemyTexture2D; }
            set { this.enemyTexture2D = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public void Update(GameTime gameTime, CastleTower baseTower)
        {
            time++;

            foreach (var al in enemy)
            {
                al.Update(gameTime);
                if (al.isAlive == false)
                {
                    enemy.Remove(al);
                }
               
            }

            if (time == 1)
            {
                if (check < Count)
                {
                    enemy.Add(new AlienEnemy(enemyTexture2D));
                    check++;
                    time++;
                }
            }
            else if (time == 100)
            {
                time = 0;
            }
             RemoveEnemy(baseTower);
        }

        public void RemoveEnemy(CastleTower baseTower)
        {
            foreach (var en in enemy)
            {
                if (en.position == 799.9962f)
                {
                   
                    en.Velocity.X = 1000;
                    en.Velocity.Y = 1000;
                    baseTower.RemoveHealth();
                    
                }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var en in enemy)
            {
                en.Draw(spriteBatch);
            }
        }
    }
}
