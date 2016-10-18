using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFed.Core
{
    public abstract class BaseTile : IDrawable
    {
        protected TileType _type;
        protected TileGroup _group;
        protected string _description;
        protected Texture2D _texture;
        protected bool _isVisible;

        public int DrawOrder
        {
            get
            {
                return GetDrawOrder();
            }
        }

        public bool Visible
        {
            get
            {
                return _isVisible;
            }
        }

        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        public BaseTile()
        {
            _group = TileGroup.Empty;
        }

        public abstract void Draw(GameTime gameTime);
        public abstract string GetDescription();
        public abstract List<TileGroup> GetTileGroups();
        public abstract TileType GetTileType();

        private int GetDrawOrder()
        {
            switch (_group)
            {
                case TileGroup.Empty:
                    return 0;
                case TileGroup.Ground:
                    return 1;
                case TileGroup.Wall:
                    return 2;
                case TileGroup.Door:
                    return 3;
                case TileGroup.Window:
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
