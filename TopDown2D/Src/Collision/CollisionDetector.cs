using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Collision
{
  public class CollisionDetector
  {
    public static void DetectCollisions(List<Collider> colliders)
    {
      //TODO: hyvä algoritmi kaikkien collisioneiden selvittämiseen
      if (colliders.Count < 2)
      {
        return;
      }
      
      //TODO: parempi algoritmi kaikkien collisioneiden selvittämiseen
      for (int i = 0; i < colliders.Count - 1; i++)
      {
        var collider1 = colliders.ElementAt(i);
        for (int j = i + 1; j < colliders.Count; j++)
        {
          var collider2 = colliders.ElementAt(j);
          if (collider1.Collision(collider2))
          {
            collider1.OnCollision(collider2);
            collider2.OnCollision(collider1);
          }
        }
      }
    }
  }
}
