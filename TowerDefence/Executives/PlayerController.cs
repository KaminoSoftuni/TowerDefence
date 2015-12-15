
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace KaminoTD.Executives
{
    using System;

    public class PlayerController
    {
        Texture2D texture;
        Vector2 position;
        public PlayerController(Texture2D texture)
        {
            this.TextureOne = texture;
        }

        public Texture2D TextureOne
        {
            get { return this.texture; }
            set { this.texture = value; }
        }



        public void Initialize(GraphicsDeviceManager graphics)
        {
            position = new Vector2(graphics.GraphicsDevice.Viewport.Width,
                                   graphics.GraphicsDevice.Viewport.Height);
        }

        public void Update()
        {
            MouseState state = Mouse.GetState();
            position.X = state.X;
            position.Y = state.Y;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, origin: new Vector2(64, 64));
        }
    }
}
