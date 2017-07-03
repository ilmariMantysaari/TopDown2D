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
      //var weapon = new Enemy();

    }
  }
}
