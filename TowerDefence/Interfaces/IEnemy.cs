

namespace KaminoTD.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IEnemy : IGameObject
    {
        int LifePoints { get; }

        void Update(GameTime gameTime);

        void Draw(SpriteBatch spriteBatch);

        int Bounty { get; }

        bool IsAlive { get; }
    }
}
