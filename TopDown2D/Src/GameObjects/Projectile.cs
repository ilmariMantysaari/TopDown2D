using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.GameObjects
{
  public class Projectile : GameObject
  {
    public Projectile()
    {
      this.behavior = new ProjectileBehavior(this);
    }
  }

  public class ProjectileBehavior : Behavior
  {
    public ProjectileBehavior(GameObject parent) : base(parent)
    {
    }

    public override void Update()
    {
      
    }
  }
}
