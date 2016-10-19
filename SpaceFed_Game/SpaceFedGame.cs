using System.Linq.Expressions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpaceFed.Core;

namespace SpaceFed
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class SpaceFedGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Grid _grid;
        private Texture2D _tileSet;
        private int _prevMouseState;
        private float _zoomLevel;

        public SpaceFedGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.ApplyChanges();
            
            
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            int height = 32;
            int width = 32;
            byte[,] gridValues = new byte[height*width, 2];

            _prevMouseState = 1;
            _zoomLevel = 1;

            for (int i = 0; i < height*width; i++)
            {
                gridValues[i, 0] = 0x01;
                gridValues[i, 1] = 0x01;
            }

            _grid = new Grid();
            _grid.InitGrid(height, width, gridValues, 1f);

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _tileSet = Content.Load<Texture2D>("tiles_128_128");
            // TODO: use this.Content to load your game content here.
        }

        protected override void UnloadContent()
        {
            Content.Unload();
        }

        protected override void Update(GameTime gameTime)
        {
            if ((GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            MouseState mouseState = Mouse.GetState();
            if (mouseState.ScrollWheelValue > _prevMouseState)
            {
                _zoomLevel *= 1.1f;
            }
            else if(mouseState.ScrollWheelValue < _prevMouseState)
            {
                _zoomLevel /= 1.1f;
            }
            _prevMouseState = mouseState.ScrollWheelValue;
            
            _grid.Update(gameTime, _zoomLevel);

            // TODO: Add your update logic here.
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here.
            _spriteBatch.Begin();

            _grid.Draw(gameTime, _spriteBatch, _tileSet);
            //_spriteBatch.Draw(_tileSet, new Rectangle(0, 0, 1024, 1024), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
