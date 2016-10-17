using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFed.Core.Grid.Tiles
{
    public class EmptyTile : ITile
    {
        public EmptyTile(ITile tile, GraphicsDevice device) : base(tile, device)
        {
            _description = "Empty;";
            _tileType = TileType.Empty;
            _texture = new Texture2D(device, 128, 128);
        }

        public void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public List<TileType> GetTileTypes()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
