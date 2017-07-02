using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D
{
  public class Transform
  {
    public Vector2 position;

    public float rotation;

    public GameObject parent;

    public Transform(GameObject parent)
    {
      this.parent = parent;
      this.rotation = 0f;
    }
  }
}
