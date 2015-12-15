using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using KaminoTD.Interfaces;

namespace KaminoTD.GameObjects.Enemies
{
    using Geometry;

    public class Enemy : IEnemy
    {
        private Texture2D enemy;
        public Vector2 Velocity;
        public float position;
        private int health;
        public bool isAlive;

        public Enemy(Texture2D enemy, int healt)
        {
            this.EnemyOne = enemy;
            position = Velocity.X + Velocity.Y;
            this.Health = healt;
            this.Velocity = new Vector2(3 * 32, 0);
            this.isAlive = true;
        }

        public virtual int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int LifePoints { get; set; }
        public int Attack { get; set; }

        public Texture2D EnemyOne
        {
            get { return this.enemy; }
            set { this.enemy = value; }
        }

        public void Update(GameTime gameTime)
        {

            var move = 32 * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (isAlive)
            {
                if (Velocity.X == 3 * 32 && Velocity.Y < 4 * 32)
                {
                    this.Velocity.Y += move;

                }
                else if (Velocity.Y == 128.533325f && Velocity.X < 14 * 32)
                {
                    this.Velocity.X += move;

                }
                else if (Velocity.X == 448.532074f && Velocity.Y < 8 * 32)
                {
                    this.Velocity.Y += move;
                }
                else if (Velocity.Y == 256.001678f && Velocity.X > 7 * 32 && Velocity.X < 15 * 32)
                {
                    this.Velocity.X -= move;
                }
                else if (Velocity.X == 223.467911f && Velocity.Y < 11 * 32)
                {
                    this.Velocity.Y += move;
                }
                else if (Velocity.Y == 352.0002f && Velocity.X < 20 * 32)
                {
                    this.Velocity.X += move;
                }
                else if (Velocity.X == 640.5292f && Velocity.Y > 5 * 32)
                {
                    Velocity.Y -= move;
                }

                position = Velocity.X + Velocity.Y;
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (position != 799.9962f)
            {
                spriteBatch.Draw(enemy, new Vector2(Velocity.X, Velocity.Y), Color.White);
                
            }
           
        }

  

        public int Bounty { get; set; }
        public bool IsAlive { get; set; }
        

        public Point Coordinates { get; set; }
    }
}
