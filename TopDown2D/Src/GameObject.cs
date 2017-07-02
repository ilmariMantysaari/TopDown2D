using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;
using TopDown2D.Textures;

namespace TopDown2D
{
  public class GameObject
  {
    public Collider collider;

    public Graphic graphic;

    public Transform transform;

    public Behavior behavior;

    /// <summary>
    /// Return the 'central point' of object.
    /// This used for rotation and positioning of colliders
    /// </summary>
    /// <returns></returns>
    public Vector2 origin;

    public GameObject()
    {
      transform = new Transform(this);
      origin = Vector2.Zero;
    }

    public virtual void OnCollision(Collider obj)
    {
      Debug.WriteLine("Collision");
    }
  }
}
