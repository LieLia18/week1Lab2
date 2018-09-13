using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace week1Lab2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D _txBoard;
        Texture2D _txPac;
        SoundEffect _backingTrack;
        SpriteFont Font;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            _txBoard = Content.Load<Texture2D>(@"Texture/gameboard");
            _txPac = Content.Load<Texture2D>(@"Texture/pac");
            _backingTrack = Content.Load<SoundEffect>(@"Audio/1b");
            Font = Content.Load<SpriteFont>(@"Fonts/GameFont");
            _backingTrack.Play();
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);
            spriteBatch.Begin();
            spriteBatch.Draw(_txBoard, new Rectangle(110, 110, _txBoard.Width/2, _txBoard.Height/2), Color.White);
            //(_txPac, GraphicsDevice.Viewport.Bounds.Center.Vector2)
            spriteBatch.Draw(_txPac, new Rectangle(200, 200, _txPac.Width/2, _txPac.Height/2), Color.White);
            //(_txBoard, GraphicsDevice.Viewport.Bounds)
            spriteBatch.DrawString(Font, "Hello Geogrie, I am Pennywise the Dancing Clown, This is a Nice Boat It will Float with you down here", new Vector2(100, 100), Color.PaleVioletRed);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
