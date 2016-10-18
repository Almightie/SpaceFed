using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFed.Core
{
    public class Grid
    {
        private BaseTile[,] _tiles;

        public Grid()
        {
            
        }

        public void InitGrid(int height, int width, byte[,] tileValues)
        {
            _tiles = new BaseTile[height, width];

            int index = 0;
            if (tileValues.Length == height*width)
            {
                for (int heightCount = 0; heightCount < height; heightCount++)
                {
                    for (int widthCount = 0; widthCount < width; widthCount++)
                    {
                        TileGroup group = (TileGroup) tileValues[index, 0];
                        TileType type = (TileType) tileValues[index, 1];

                        AbstractTileFactory factory;
                        switch (group)
                        {
                            case TileGroup.Ground:
                                factory = new GroundTileFactory();
                                break;
                            case TileGroup.Wall:
                                factory = new WallTileFactory();
                                break;
                            default:
                                factory = new GroundTileFactory();
                                break;

                        }

                        _tiles[heightCount, widthCount] = factory.CreateTile(type);
                        index++;
                    }
                }
            }
            else
            {
                // Todo: Logwrite error since the numbers do not add up
            }
        }
    }
}
