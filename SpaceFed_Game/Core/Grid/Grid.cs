using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFed.Core
{
    public class Grid
    {
        private const int cTileWidth  = 128;
        private const int cTileHeight = 128;
        

        private BaseTile[,] _tiles;
        private float _zoomLevel;

        public Grid()
        {
        }

        public void InitGrid(int height, int width, byte[,] tileValues, float zoomFactor)
        {
            _tiles = new BaseTile[height, width];
            _zoomLevel = 1f / zoomFactor;

            int index = 0;
            if (tileValues.GetLength(0) == height*width)
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

        public void Update(GameTime gameTime, float zoomFactor)
        {
            _zoomLevel = 1f / zoomFactor;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D texture)
        {
            for(int i = 0; i < _tiles.GetLength(0); i++)
            {
                for (int j = 0; j < _tiles.GetLength(1); j++)
                {
                    Vector2 position = new Vector2(j * (int)(cTileWidth / _zoomLevel), i * (int)(cTileHeight / _zoomLevel));
                    Rectangle rect = new Rectangle(0, 0, 128, 128);
                    spriteBatch.Draw(texture, null, new Rectangle((int)position.X, (int)position.Y, (int)(rect.Width / _zoomLevel), (int)(rect.Height / _zoomLevel)), rect);
                }
            }
        }

        public int DrawOrder { get; }
        public bool Visible { get; }
        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;
    }
}
