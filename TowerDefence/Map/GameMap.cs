using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace KaminoTD.Map
{
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

        public bool IsOnPath(int i, int j)
        {
            if (j == 3 * 32 && i < 5 * 32)
            {
                return true;
            }
                else if (i == 4 * 32 && (j > 3 * 32 && j < 15 * 32))
                {
                    return true;
                }
                else if (j == 14 * 32 && (i > 4 * 32 && i < 9 * 32))
                {
                    return true;
                }
                else if (i == 8 * 32 && (j < 15 * 32 && j > 6 * 32))
                {
                    return true;
                }
                else if (j == 7 * 32 && (i > 8 * 32 && i < 12 * 32))
                {
                    return true;
                }
                else if (i == 11 * 32 && (j > 7 * 32 && j < 21 * 32))
                {
                    return true;
                }
                else if (j == 20 * 32 && (i < 11 * 32 && i > 4 * 32))
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
                    if (IsOnPath(i,j))
                    {
                        spriteBatch.Draw(stone, new Vector2(j, i), Color.White);
                    }
                    else if (IsOnPath(i, j))
                    {
                        spriteBatch.Draw(stone, new Vector2(j, i), Color.White);
                    }
                    else if (IsOnPath(i, j))
                    {
                        spriteBatch.Draw(stone, new Vector2(j, i), Color.White);
                    }
                    else if (IsOnPath(i, j))
                    {
                        spriteBatch.Draw(stone, new Vector2(j, i), Color.White);
                    }
                    else if (IsOnPath(i, j))
                    {
                        spriteBatch.Draw(stone, new Vector2(j, i), Color.White);
                    }
                    else if (IsOnPath(i, j))
                    {
                        spriteBatch.Draw(stone, new Vector2(j, i), Color.White);
                    }
                    else if (IsOnPath(i, j))
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

