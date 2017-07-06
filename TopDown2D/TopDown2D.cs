using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TopDown2D.Scenes;

namespace TopDown2D
{
  /// <summary>
  /// This is the main type for your game.
  /// </summary>
  public class TopDown2D : Game
  {
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;
    Scene currentScene;

    public static Viewport viewport;

    public static Texture2D playerTexture;
    public static Texture2D enemyTexture;
    public static Texture2D mapTexture;
    public static Texture2D weaponTexture;

    public TopDown2D()
    {
      graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";
    }
    
    protected override void Initialize()
    {
      base.Initialize();
      InputConfig.Load();
      viewport = GraphicsDevice.Viewport;
      currentScene = new Level1();
    }
    
    protected override void LoadContent()
    {
      spriteBatch = new SpriteBatch(GraphicsDevice);
      //For time being, all content is loaded here at once
      playerTexture = Content.Load<Texture2D>("blue_circle");
      enemyTexture = Content.Load<Texture2D>("red_circle");
      mapTexture = Content.Load<Texture2D>("green_tile_grid");
      weaponTexture = Content.Load<Texture2D>("blue_circle");
    }

    protected override void UnloadContent()
    {
    }
    
    protected override void Update(GameTime gameTime)
    {
      if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        Exit();
      
      currentScene.Update();

      base.Update(gameTime);
    }
    
    protected override void Draw(GameTime gameTime)
    {
      GraphicsDevice.Clear(Color.Black);

      currentScene.Draw(spriteBatch);

      base.Draw(gameTime);
    }
  }
}
