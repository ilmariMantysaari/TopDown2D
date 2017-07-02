using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.GameObjects
{
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
        parent.transform.position += new Vector2(0, -10);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerDown))
      {
        parent.transform.position += new Vector2(0, 10);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerRight))
      {
        parent.transform.position += new Vector2(10, 0);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerLeft))
      {
        parent.transform.position += new Vector2(-10, 0);
      }
      if (Keyboard.GetState().IsKeyDown(Keys.Q))
      {
        parent.transform.rotation += 0.01f;
      }
    }
  }
}
