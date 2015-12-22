

namespace KaminoTD.GameObjects.Enemies
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class EnemyOnMap
    {
        private readonly IList<Enemy> enemy;

        private int count;
        private int check = 0;
        private int time = 0;
        private CastleTower castle;
        private Texture2D enemyTexture2D;

        public EnemyOnMap(Texture2D enemy, int count , CastleTower castle)
        {
            this.Count = count;
            this.enemyTexture2D = enemy;
            this.enemy = new List<Enemy>();
            this.castle = castle;
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

        public void Update(GameTime gameTime)
        {
            time++;

            foreach (var al in enemy)
            {
                al.Update(gameTime);
               
            }

            if (time == 1)
            {
                if (check < Count)
                {
                    enemy.Add(new AlienEnemy(enemyTexture2D, castle));
                    check++;
                    time++;
                }
            }
            else if (time == 100)
            {
                time = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var en in enemy)
            {
                en.Draw(spriteBatch);
            }
        }

        public IList<Enemy> getEnemyOnTheMap()
        {
            return enemy;
        }
    }
}
