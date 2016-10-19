using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFed.Core
{
    public class DirtTile : TileDecorator
    {
        public DirtTile(BaseTile tile) : base(tile)
        {
            _group = TileGroup.Ground;
            _type = TileType.Dirt;
            _description = "Dirty Ground";
        }

        public override void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
