using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SpaceFed.Core
{
    public class EmptyTile : BaseTile
    {
        public EmptyTile()
        {
            _group = TileGroup.Empty;
            _type = TileType.Unknown;
            _description = "Empty Tile";
        }

        public override void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override List<TileGroup> GetTileGroups()
        {
            return new List<TileGroup>(new TileGroup[] { _group });
        }

        public override TileType GetTileType()
        {
            return _type;
        }
    }
}
