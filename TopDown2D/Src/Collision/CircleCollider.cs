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
    public GameObject gameObject { get; set; }

    public CircleCollider(GameObject parent, int radius)
    {
      this.radius = radius;
      this.gameObject = parent;
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
      var pos = this.gameObject.origin + this.gameObject.transform.Position;
      var pos2 = circle.gameObject.origin + circle.gameObject.transform.Position;
      var distX = pos.X - pos2.X;
      var distY = pos.Y - pos2.Y;

      return distX * distX + distY * distY <= rad * rad;
    }
  }
}
