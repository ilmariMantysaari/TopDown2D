using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Collision
{
  public interface Collider
  {
    GameObject gameObject { get; set; }
    CollisionEffect effect { get; set; }

    //TODO: pitäisiköhän muuttaa abstrakti luokaksi ja hoitaa lapsien collision täällä
    bool Collision(Collider collider);
    void OnCollision(Collider obj);
  }

  public enum CollisionEffect
  {
    Damage, Heal, Stop
  }
}
