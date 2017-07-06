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

namespace TopDown2D
{
  public class GameObject
  {
    public Collider collider;

    public Renderer renderer;

    public Transform transform;

    public Behavior behavior;

    //the parent gameobject
    //There's necessarily no parent gameobject if this object is direct child of the scene
    //If parent is present, the gameobject is rendered relative to parent
    public GameObject parent;
    public List<GameObject> children;

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
      Debug.WriteLine("Collision" + this);
    }

    public virtual void AddChild(GameObject obj)
    {
      if (this.children == null)
      {
        this.children = new List<GameObject>();
      }
      this.children.Add(obj);
      obj.parent = this;
    }
  }
}
