namespace KaminoTD.Menu
{
    using System.Threading;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Graphics;

    //Enumeration for the game windows
    public enum GameState
    {
        Menu = 0,
        Game = 1,
        Exit = 2
    }

    //Enumeration for the main menu
    public enum MainMenuScreen
    {
        NewGame = 0,
        LoadGame = 1,
        Exit = 2
    }
    public class MainMenu
    {
        private Game game = new Game();

        public GameState gameState;
        private MainMenuScreen mainMenuScreen;
        private KeyboardState currentKeyboardState;
        private KeyboardState previousKeyboardState;
        private int mainMenuScreenIndex;

        private Texture2D mainMenuBackground;
        private Texture2D newGameHovered;
        private Texture2D newGamePressed;
        private Texture2D newGamePlain;
        private Texture2D exitGameHovered;
        private Texture2D exitGamePressed;
        private Texture2D exitGamePlain;
        private Texture2D loadGameHovered;
        private Texture2D loadGamePressed;
        private Texture2D loadGamePlain;

        public MainMenu(Texture2D mainMenuBackground, Texture2D newGameHovered, Texture2D newGamePressed, Texture2D newGamePlain, Texture2D exitGameHovered, Texture2D exitGamePressed, Texture2D exitGamePlain, Texture2D loadGameHovered, Texture2D loadGamePressed, Texture2D loadGamePlain)
        {
            this.mainMenuBackground = mainMenuBackground;
            this.newGameHovered = newGameHovered;
            this.newGamePressed = newGamePressed;
            this.newGamePlain = newGamePlain;
            this.exitGameHovered = exitGameHovered;
            this.exitGamePressed = exitGamePressed;
            this.exitGamePlain = exitGamePlain;
            this.loadGameHovered = loadGameHovered;
            this.loadGamePressed = loadGamePressed;
            this.loadGamePlain = loadGamePlain;

            gameState = GameState.Menu;
            mainMenuScreen = MainMenuScreen.NewGame;
            mainMenuScreenIndex = 0;
            currentKeyboardState = Keyboard.GetState();
        }

        public GameState GameState { get { return this.gameState; } }

        public void Update()
        {
            previousKeyboardState = currentKeyboardState;
            currentKeyboardState = Keyboard.GetState();
            if (currentKeyboardState.IsKeyDown(Keys.Down) && previousKeyboardState.IsKeyUp(Keys.Down) && mainMenuScreenIndex >= 2)
            {
                this.mainMenuScreenIndex = 0;
            }
            else if (currentKeyboardState.IsKeyDown(Keys.Up) && previousKeyboardState.IsKeyUp(Keys.Up) && mainMenuScreenIndex <= 0)
            {
                this.mainMenuScreenIndex = 2;
            }
            else if (currentKeyboardState.IsKeyDown(Keys.Up) && previousKeyboardState.IsKeyUp(Keys.Up))
            {
                this.mainMenuScreenIndex--;
            }
            else if (currentKeyboardState.IsKeyDown(Keys.Down) && previousKeyboardState.IsKeyUp(Keys.Down))
            {
                this.mainMenuScreenIndex++;
            }
            else if (currentKeyboardState.IsKeyDown(Keys.Enter))
            {
                switch ((int)this.mainMenuScreenIndex)
                {
                    case 0: this.gameState = GameState.Game;
                        break;
                    //case 1:
                    //    this.gameState = ;
                    //    break;
                    case 2:
                        this.gameState = GameState.Exit;
                        break;
                };
            }
        }

        public void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(mainMenuBackground, new Rectangle(0, 0, graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height), Color.White);
            spriteBatch.Draw(newGamePlain, new Rectangle(graphicsDevice.Viewport.Width / 2 - 90, graphicsDevice.Viewport.Height / 7, 180, 30), Color.White);
            spriteBatch.Draw(loadGamePlain, new Rectangle(graphicsDevice.Viewport.Width / 2 - 90, graphicsDevice.Viewport.Height / 4, 180, 30), Color.White);
            spriteBatch.Draw(exitGamePlain, new Rectangle(graphicsDevice.Viewport.Width / 2 - 90, graphicsDevice.Viewport.Height / 3 + 60, 180, 30), Color.White);
            if (this.mainMenuScreenIndex == 0)
            {
                spriteBatch.Draw(newGameHovered, new Rectangle(graphicsDevice.Viewport.Width / 2 - 90, graphicsDevice.Viewport.Height / 7, 180, 30), Color.White);
            }
            else if (this.mainMenuScreenIndex == 1)
            {
                spriteBatch.Draw(loadGameHovered, new Rectangle(graphicsDevice.Viewport.Width / 2 - 90, graphicsDevice.Viewport.Height / 4, 180, 30), Color.White);
            }
            else if (this.mainMenuScreenIndex == 2)
            {
                spriteBatch.Draw(exitGameHovered, new Rectangle(graphicsDevice.Viewport.Width / 2 - 90, graphicsDevice.Viewport.Height / 3 + 60, 180, 30), Color.White);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Enter))
            {
                switch ((int)this.mainMenuScreenIndex)
                {
                    case 0:
                        spriteBatch.Draw(newGamePressed, new Rectangle(graphicsDevice.Viewport.Width / 2 - 90, graphicsDevice.Viewport.Height / 7, 180, 30), Color.White);
                        break;
                    //case 1:
                    //    this.gameState = ;
                    //    break;
                    case 2:
                        spriteBatch.Draw(exitGamePressed, new Rectangle(graphicsDevice.Viewport.Width / 2 - 90, graphicsDevice.Viewport.Height / 3 + 60, 180, 30), Color.White);
                        break;
                };
            }
            spriteBatch.End();
        }
    }
}
