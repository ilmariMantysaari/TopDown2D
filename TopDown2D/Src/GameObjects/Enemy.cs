using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
      renderer = new Renderer(this)
      {
        texture = TopDown2D.enemyTexture
      };

      collider = new CircleCollider(this, renderer.texture.Height / 2);
      origin = new Vector2(renderer.texture.Width / 2, renderer.texture.Height / 2);
      this.behavior = new EnemyBehavior(this);
    }
  }

  public class EnemyBehavior : Behavior
  {
    public EnemyBehavior(GameObject parent) : base(parent)
    {
    }

    public override void Update()
    {
      gameObject.transform.Position += new Vector2(0, 1);
    }
  }
}
