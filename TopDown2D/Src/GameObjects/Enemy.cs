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

    //TODO: remove this moevement logic, just for testing enemy movement
    //Enemy just moves up and down
    private int distance = 100;
    private int counter = 0;
    private int dir = 5;

    public override void Update()
    {
      counter++;
      if (counter < 0 || counter > distance)
      {
        counter = 0;
        dir *= -1;
      }
      gameObject.transform.Position += new Vector2(0, dir);
    }
  }
}
