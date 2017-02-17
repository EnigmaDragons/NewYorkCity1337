using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using NewYorkCity1337.Graphics;

namespace NewYorkCity1337.Engine
{
    public class MainGame : Game, INavigator
    {
        private SpriteBatch _sprites;
        private IGameView _currentView;
        private GraphicsDeviceManager _graphicsManager;

        public MainGame(IGameView startingView)
        {
            _graphicsManager = new GraphicsDeviceManager(this);
            _graphicsManager.PreferredBackBufferWidth = new TileSize().Get() * 30;
            _graphicsManager.PreferredBackBufferHeight = new TileSize().Get() * 16; 
            _currentView = startingView;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;
            _sprites = new SpriteBatch(GraphicsDevice);
            new GameInstance().SetGame(this);
            new SpritesBatchInstance().SetSpritesBatch(_sprites);
            DefaultFont.Load(Content);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            IsMouseVisible = true;
            _currentView?.LoadContent();
        }

        protected override void UnloadContent()
        {
            Content.Unload();
            _currentView?.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _currentView?.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _sprites.Begin(SpriteSortMode.Deferred, null, SamplerState.PointClamp);
            _currentView?.Draw();
            _sprites.End();
            base.Draw(gameTime);
        }

        public void NavigateTo(string viewName)
        {
            throw new System.Exception("No known views");
        }

        private void NavigateTo(IGameView view)
        {
            view.LoadContent();
            _currentView?.UnloadContent();
            _currentView = view;
        }
    }
}
