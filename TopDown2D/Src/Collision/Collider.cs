﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Collision
{
  public interface Collider
  {
    GameObject parent { get; set; }
    CollisionEffect effect { get; set; }

    bool Collision(Collider collider);
  }
  public enum CollisionEffect
  {
    Damage, Heal
  }
}
