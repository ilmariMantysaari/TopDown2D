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
    public GameObject parent;

    public virtual bool Collision(Collider collider)
    {
      return false;
    }

    public virtual void OnCollision(Collider collider)
    {
    }

  }
}
