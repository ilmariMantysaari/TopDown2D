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
      transform.position = new Vector2(300, 100);
      graphic = new Textures.Graphic(this)
      {
        texture = TopDown2D.playerTexture
      };
      collider = new CircleCollider(this, graphic.texture.Width / 2);
      origin = new Vector2(graphic.texture.Width / 2, graphic.texture.Height / 2);
      this.behavior = new PlayerBehavior(this);
    }

  }
}
