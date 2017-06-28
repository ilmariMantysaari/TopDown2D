using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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


    public TopDown2D()
    {
      graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";
    }
    
    protected override void Initialize()
    {
      base.Initialize();
    }
    
    protected override void LoadContent()
    {
      spriteBatch = new SpriteBatch(GraphicsDevice);
      //For time being, all content is loaded here at once

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
      GraphicsDevice.Clear(Color.CornflowerBlue);

      currentScene.Draw();

      base.Draw(gameTime);
    }
  }
}
