using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Collision
{
  public class CircleCollider : Collider
  {
    public int radius;
    public CollisionEffect effect { get; set; }
    public GameObject parent { get; set; }

    public CircleCollider(GameObject parent, int radius)
    {
      this.radius = radius;
      this.parent = parent;
    }

    public bool Collision(Collider collider)
    {
      if (collider.GetType() == typeof(CircleCollider))
      {
        return IntersectCircle((CircleCollider)collider);
      }
      return false;
    }

    public bool IntersectCircle(CircleCollider circle)
    {
      var rad = this.radius + circle.radius;
      var pos = this.parent.origin + this.parent.position;
      var pos2 = circle.parent.origin + circle.parent.position;
      var distX = pos.X - pos2.X;
      var distY = pos.Y - pos2.Y;

      return distX * distX + distY * distY <= rad * rad;
    }
  }
}
