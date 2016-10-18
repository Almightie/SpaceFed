using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SpaceFed.Core
{
    public class WoodenWallTile : TileDecorator
    {
        public WoodenWallTile(BaseTile tile) : base(tile)
        {
            _group = TileGroup.Wall;
            _type = TileType.Wood;
            _description = "Wooden Wall";
        }

        public override void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }

        public override List<TileGroup> GetTileGroups()
        {
            throw new NotImplementedException();
        }
    }
}
