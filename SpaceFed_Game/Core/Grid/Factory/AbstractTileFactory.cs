using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFed.Core
{
    public abstract class AbstractTileFactory
    {
        public abstract BaseTile CreateTile(TileType type);
    }
}
