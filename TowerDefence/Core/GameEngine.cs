
namespace KaminoTD.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using GameObjects;
    using GameObjects.Enemies;
    using Geometry;
    using Interfaces;
    using Map;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class GameEngine : IEngine
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D grass;
        private Texture2D stone;
        private Texture2D tower;
        private Texture2D enemy;
        private Texture2D mario;
        private Texture2D fireBall;
        private GameMap map;
        private CastleTower baseTower;
        private EnemyOnMap alien;
        private Vector2 position;
        private Vector2 firePosition;
        private Enemy enemyInRange;

        public void TakeEnemyInRange(IList<Enemy> enemys)
        {
            if (enemyInRange == null)
            {
                enemyInRange = enemys.FirstOrDefault(t => t.isAlive);
            }

            double distance = double.MaxValue;

            if (enemyInRange != null)
            {
                distance = GeometryCalcs.CalculateDistance(position, enemyInRange.vector);
            }

            double ballDistance = GeometryCalcs.CalculateDistance(firePosition, enemyInRange.vector);

            if (ballDistance > 90)
            {
                firePosition = position;
                foreach (var enemyInRangeSearch in enemys)
                {
                    if (enemyInRangeSearch.isAlive)
                    {
                        distance = GeometryCalcs.CalculateDistance(position, enemyInRangeSearch.vector);
                        if (distance < 110)
                        {
                            enemyInRange = enemyInRangeSearch;
                        }
                    }
                }
            }

            if (distance < 100 && enemyInRange != null)
            {

                if (ballDistance < 10)
                {
                    firePosition = position;
                    enemyInRange.Health -= 20;
                }

                double yDiff = enemyInRange.vector.Y - firePosition.Y;
                double xDiff = enemyInRange.vector.X - firePosition.X;

                firePosition.X += (float)xDiff / 5;
                firePosition.Y += (float)yDiff / 5;

            }
        }

        public void CheckBaseHealth(CastleTower baseTower, Texture2D gameOver)
        {
            if (baseTower.Health <= 0)
            {
               // spriteBatch.Draw(gameOver, Vector2.Zero);
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}
