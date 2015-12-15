using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefence.Interfaces
{
    public interface ICastle
    {
        Texture2D Tower { get;}
        void Draw(SpriteBatch spriteBatch);
    }
}
