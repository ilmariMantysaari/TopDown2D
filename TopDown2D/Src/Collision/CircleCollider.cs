using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Collision
{
  public class CircleCollider : ICollisionArea
  {
    public int radius;

    public CircleCollider(int diameter)
    {

    }

    public bool Collision(Collider collider)
    {
      throw new NotImplementedException();
    }
  }
}
