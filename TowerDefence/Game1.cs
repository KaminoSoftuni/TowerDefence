using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Threading;
using KaminoTD.Executives;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using KaminoTD.GameObjects;
using KaminoTD.GameObjects.Enemies;
using KaminoTD.Map;

namespace KaminoTD
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D grass;
        Texture2D stone;
        Texture2D tower;
        Texture2D enemy;
        Texture2D gameOver;
        GameMap map;
        CastleTower baseTower;
        Texture2D texture;
        PlayerController mouseController;

        EnemyOnMap alien;
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

     
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
           mouseController.Initialize(graphics);
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
            texture = this.Content.Load<Texture2D>("Mouse");
            map = new GameMap(stone, grass);
            baseTower = new CastleTower(tower);
            alien = new EnemyOnMap(enemy, 6);
            mouseController = new PlayerController(texture);
            

        }
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here

        }

     
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
           
            mouseController.Update();
            alien.Update(gameTime , baseTower);
          
            

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);
            
            // TODO: Add your drawing code here
            spriteBatch.Begin();
            mouseController.Draw(spriteBatch);
            map.Draw(spriteBatch);
            baseTower.Draw(spriteBatch);
            
           alien.Draw(spriteBatch);
            if (baseTower.Health <= 0)
            {
                spriteBatch.Draw(gameOver , Vector2.Zero , Color.White);


                Thread.Sleep(1000);
                Exit();
                
            }
            
            
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
