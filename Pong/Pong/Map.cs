using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;

namespace Pong
{
    class Map
    {
        Tile[,] mapTiles;                                       
        int[,] mapInt;

        public bool isWalckable(int i, int j)
        {
            if (mapInt[i, j] == 1)
                return false;
            else
                return true;
        }

        public Map()
        {
            mapInt = new int[,]{{0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0}};
            mapTiles = new Tile[mapInt.GetLength(0), mapInt.GetLength(1)];
            for (int i = 0; i < mapInt.GetLength(0); i++)
            {
                for (int j = 0; j < mapInt.GetLength(1); j++)
                {
                    if (mapInt[i, j] == 0)
                    {
                        mapTiles[i, j] = new Tile(true, "Pics/tile1.png", new Vector2f((float)(50 * i), (float)(50 * j)));
                    }
                    else
                    {
                        mapTiles[i, j] = new Tile(false, "Pics/tile2.png", new Vector2f((float)(50 * i), (float)(50 * j)));
                    }
                }
            }
        }

        public void draw(RenderWindow win)
        {
            for (int i = 0; i < mapInt.GetLength(0); i++)
            {
                for (int j = 0; j < mapInt.GetLength(1); j++)
                {
                    mapTiles[i, j].draw(win);
                }
            }

        }
    }
}