using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Collision
{
  public class Collider
  {

    public ICollisionArea collisionArea;

    public virtual void OnCollision()
    {

    }
  }
}
