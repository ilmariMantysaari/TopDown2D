using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;

namespace TopDown2D.GameObjects
{
  public class Projectile : GameObject
  {
    public int speed;
    
    public Projectile()
    {
      this.behavior = new ProjectileBehavior(this);
      this.renderer = new Renderer(this, TopDown2D.shotTexture);
      this.collider = new CircleCollider(this, 5);
    }

    public override void OnCollision(Collider obj)
    {
      base.OnCollision(obj);
    }
  }

  public class ProjectileBehavior : Behavior
  {
    public ProjectileBehavior(GameObject parent) : base(parent)
    {
    }

    public override void Update()
    {
      gameObject.transform.Position += new Vector2(1, 1);
    }
  }
}
