using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFed.Core
{
    public abstract class TileDecorator : BaseTile
    {
        protected BaseTile _tile;

        protected TileDecorator(BaseTile tile)
        {
            _tile = tile;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override List<TileGroup> GetTileGroups()
        {
            List<TileGroup> groups = _tile.GetTileGroups();
            groups.Add(_group);
            return groups;
        }

        public override TileType GetTileType()
        {
            return _type;
        }
    }
}
