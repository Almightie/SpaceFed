using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFed.Core
{
    public class GroundTileFactory : AbstractTileFactory
    {
        public override BaseTile CreateTile(TileType type)
        {
            switch (type)
            {
                case TileType.Dirt:
                    return new DirtTile(new EmptyTile());
                default:
                    return new EmptyTile();
            }
        }
    }
}
