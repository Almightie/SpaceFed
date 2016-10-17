using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SpaceFed.Core
{
    public interface ITile
    {
        void Draw(GameTime gameTime);
        List<TileType> GetTileTypes();
        string GetDescription();
    }
}
