
namespace KaminoTD.Map
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class GameMap
    {
        private Texture2D stone;
        private Texture2D grass;

        public GameMap(Texture2D stone, Texture2D grass)
        {
            this.Stone = stone;
            this.Grass = grass;

        }
        public Texture2D Stone
        {
            get { return this.stone; }
            set { this.stone = value; }
        }
        public Texture2D Grass
        {
            get { return this.grass; }
            set { this.grass = value; }
        }

        public static bool IsOnPath(int y, int x, int buffer)
        {

            if ((x >= 3 * 32 - buffer / 2 && x <= 3 * 32 + buffer)
                && (y < 5 * 32 + buffer))
            {
                return true;
            }
            else if ((y >= 4 * 32 - buffer && y <= 4 * 32 + buffer)
            && (x > 3 * 32 && x < 15 * 32))
            {
                return true;
            }
            else if ((x >= 14 * 32 - buffer / 2 && x <= 14 * 32 + buffer)
                && (y > 4 * 32 && y < 9 * 32))
            {
                return true;
            }
            else if ((y >= 8 * 32 - buffer && y <= 8 * 32 + buffer)
                && (x < 15 * 32 && x > 6 * 32))
            {
                return true;
            }
            else if ((x >= 7 * 32 - buffer / 2 && x <= 7 * 32 + buffer)
                && (y > 8 * 32 && y < 12 * 32))
            {
                return true;
            }
            else if ((y >= 11 * 32 - buffer && y <= 11 * 32 + buffer)
                && (x > 7 * 32 && x < 21 * 32))
            {
                return true;
            }
            else if ((x >= 20 * 32 - buffer / 2 && x <= 20 * 32 + buffer)
                && (y < 11 * 32 && y > 4 * 32))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < 464; i += 32)
            {
                for (int j = 0; j < 782; j += 32)
                {
                    if (IsOnPath(i, j, 0))
                    {
                        spriteBatch.Draw(stone, new Vector2(j, i), Color.White);
                    }
                    else
                    {
                        spriteBatch.Draw(grass, new Vector2(j, i), Color.White);
                    }

                }

            }

        }

    }

}

