using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;

namespace TopDown2D.GameObjects
{
  public class Player : GameObject
  {
    public Player()
    {
      renderer = new Renderer(this)
      {
        texture = TopDown2D.playerTexture
      };
      collider = new CircleCollider(this, renderer.texture.Width / 2);
      origin = new Vector2(renderer.texture.Width / 2, renderer.texture.Height / 2);
      this.behavior = new PlayerBehavior(this);

      //TODO: testaa lapsiobjektia tässä
      //TODO: muista lisätä update draw ym. comnponent luokkiin
      
    }
  }

  public class PlayerBehavior : Behavior
  {
    public PlayerBehavior(GameObject parent) : base(parent)
    {
    }

    public override void Update()
    {
      base.Update();
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerUp))
      {
        gameObject.transform.Position += new Vector2(0, -10);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerDown))
      {
        gameObject.transform.Position += new Vector2(0, 10);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerRight))
      {
        gameObject.transform.Position += new Vector2(10, 0);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerLeft))
      {
        gameObject.transform.Position += new Vector2(-10, 0);
      }
      if (Keyboard.GetState().IsKeyDown(Keys.Q))
      {
        gameObject.transform.rotation += 0.01f;
      }
    }
  }
}
