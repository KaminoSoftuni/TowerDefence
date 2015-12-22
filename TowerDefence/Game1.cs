

namespace KaminoTD
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using KaminoTD.GameObjects;
    using KaminoTD.GameObjects.Enemies;
    using KaminoTD.Geometry;
    using KaminoTD.Map;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Core;
    using Interfaces;

    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D grass;
        private Texture2D stone;
        private Texture2D tower;
        private Texture2D enemy;
        private Texture2D mario;
        private Texture2D fireBall;
        private Texture2D gameOver;
        private GameMap map;
        private CastleTower baseTower;
        private EnemyOnMap alien;
        private Vector2 position;
        private Vector2 firePosition;
        private Enemy enemyInRange;

        public Game1(IEngine engine)
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this.Engine = engine;
        }

        public IEngine Engine { get; set; }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            grass = this.Content.Load<Texture2D>("GrassOne");
            stone = this.Content.Load<Texture2D>("StoneOne");
            tower = this.Content.Load<Texture2D>("TowerThree");
            enemy = this.Content.Load<Texture2D>("Alien");
            gameOver = this.Content.Load<Texture2D>("GameOver");
            mario = this.Content.Load<Texture2D>("Mario");
         fireBall = this.Content.Load<Texture2D>("fire");
            map = new GameMap(stone, grass);
            baseTower = new CastleTower(tower);
            alien = new EnemyOnMap(enemy, 50, baseTower);

        }
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            alien.Update(gameTime);

            MouseState state = Mouse.GetState();

            if (state.LeftButton == ButtonState.Pressed &&
                state.X > -1 && state.Y > -1)
            {
                var mousePosition = new Vector2(state.X, state.Y);

                if (!GameMap.IsOnPath((int)mousePosition.Y, (int)mousePosition.X, 32) &&
                    !CastleTower.IsOnCastle((int)mousePosition.Y, (int)mousePosition.X, 32))
                {
                    position.X = state.X;
                    position.Y = state.Y;
                }
            }

            IList<Enemy> enemys = alien.getEnemyOnTheMap();

            TakeEnemyInRange(enemys);

            base.Update(gameTime);
        }
       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            map.Draw(spriteBatch);
            baseTower.Draw(spriteBatch);

            alien.Draw(spriteBatch);

            this.Engine.CheckBaseHealth(baseTower,gameOver);

            if (position.X > -1 && position.Y > -1)
            {
                spriteBatch.Draw(mario, position, Color.White);
            }

            spriteBatch.Draw(fireBall, firePosition);

            spriteBatch.End();

            base.Draw(gameTime);
        }
        
        private void TakeEnemyInRange(IList<Enemy> enemys)
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
                    enemyInRange.Health -= 4;
                    if (enemyInRange.Health <= 0)
                    {
                        enemyInRange.isAlive = false;
                    }
                    
                }

                double yDiff = enemyInRange.vector.Y - firePosition.Y;
                double xDiff = enemyInRange.vector.X - firePosition.X;

                firePosition.X += (float)xDiff / 5;
                firePosition.Y += (float)yDiff / 5;

            }
        }
    }
}
