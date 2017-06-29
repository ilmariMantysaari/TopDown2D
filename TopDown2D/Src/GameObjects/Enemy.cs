using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;

namespace TopDown2D.GameObjects
{
  public class Enemy : GameObject
  {
    public Enemy()
    {
      position = new Vector2(300, 228);
      graphic = new Textures.Graphic(this)
      {
        texture = TopDown2D.enemyTexture
      };
      collider = new CircleCollider(this, graphic.texture.Height / 2);
      origin = new Vector2(graphic.texture.Width / 2, graphic.texture.Height / 2);
    }
  }
}
