
namespace KaminoTD.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IGameObject
    {
        Vector2 Coordinates { get; set; }

        Texture2D Visualization { get; }

        bool Exists { get; }

        void Draw(SpriteBatch spriteBatch);      
    }
}

