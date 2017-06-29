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
      position = new Vector2(300, 100);
      graphic = new Textures.Graphic(this)
      {
        texture = TopDown2D.playerTexture
      };
      collider = new CircleCollider(this, graphic.texture.Width / 2);
      origin = new Vector2(graphic.texture.Width / 2, graphic.texture.Height / 2);
    }

    public override void Update()
    {
      base.Update();
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerUp))
      {
        this.position += new Vector2(0, -10);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerDown))
      {
        this.position += new Vector2(0, 10);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerRight))
      {
        this.position += new Vector2(10, 0);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerLeft))
      {
        this.position += new Vector2(-10, 0);
      }
      if (Keyboard.GetState().IsKeyDown(Keys.Q))
      {
        this.rotation += 0.01f;
      }
    }
  }
}
