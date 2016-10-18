using System.Linq.Expressions;
using Microsoft.Xna.Framework;
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

        public SpaceFedGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            int height = 32;
            int width = 32;
            byte[,] gridValues = new byte[height*width, 2];
            for (int i = 0; i < height*width; i++)
            {
                gridValues[i, 0] = 0x01;
                gridValues[i, 1] = 0x01;
            }

            _grid = new Grid();
            _grid.InitGrid(height, width, gridValues);

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here.
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here.
        }

        protected override void Update(GameTime gameTime)
        {
            if ((GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            // TODO: Add your update logic here.

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here.

            base.Draw(gameTime);
        }
    }
}
