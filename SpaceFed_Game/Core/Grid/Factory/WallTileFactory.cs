using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFed.Core
{
    public class WallTileFactory : AbstractTileFactory
    {
        public override BaseTile CreateTile(TileType type)
        {
            switch (type)
            {
                case TileType.Wood:
                    return new WoodenWallTile(new EmptyTile());
                default:
                    return new EmptyTile();
            }
        }
    }
}
