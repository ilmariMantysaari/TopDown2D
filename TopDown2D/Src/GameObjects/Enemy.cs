using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.GameObjects
{
  public class Enemy : GameObject
  {
    public Enemy()
    {
      this.behavior = new EnemyBehavior(this);
      this.transform = new Transform(this)
      {
        Position = new Vector2(300, 228)
      };
      this.renderer = new Renderer(this)
      {
        texture = TopDown2D.enemyTexture
      };

    }
  }

  public class EnemyBehavior : Behavior
  {
    public EnemyBehavior(GameObject parent) : base(parent)
    {
    }

    public override void Update()
    {

    }
  }
}
