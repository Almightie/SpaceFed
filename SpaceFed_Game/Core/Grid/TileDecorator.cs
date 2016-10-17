using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFed.Core
{
    public class TileDecorator : ITile
    {
        private ITile _tile;
        protected TileType _tileType;
        protected string _description;
        protected Texture2D _texture;

        protected TileDecorator(ITile tile, GraphicsDevice device)
        {
            _tile = tile;
        }

        public void Draw(GameTime gameTime)
        {
            
        }

        public List<TileType> GetTileTypes()
        {
            List<TileType> types = GetTileTypes();
            types.Add(_tileType);
            return types;
        }

        public string GetDescription()
        {
            return _tile.GetDescription() + _description;
        }
    }
}
