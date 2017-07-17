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

    //The scene this gameobject is in
    protected Scene scene;
    public Scene Scene {
      get
      {
        if (this.parent != null)
        {
          return parent.Scene;
        }
        return scene;
      }
      set
      {
        scene = value;
      }
    }

    //the parent gameobject
    //There's necessarily no parent gameobject if this object is direct child of the scene
    //If parent is present, the gameobject is rendered relative to parent
    //TODO: onko hyvä idea?
    public GameObject parent;
    public List<GameObject> children;

    /// <summary>
    /// Return the 'central point' of object.
    /// This used for rotation and positioning of colliders
    /// </summary>
    /// <returns></returns>
    //TODO: pitäisiköhän lykätä transformiin
    public Vector2 origin;
    
    public GameObject()
    {
      transform = new Transform(this);
      origin = Vector2.Zero;
    }

    public GameObject(Collider collider = null, Renderer renderer = null, Transform transform = null, Behavior behavior = null)
    {
      this.collider = collider;
      this.renderer = renderer;
      this.transform = transform;
      this.behavior = behavior;
    }

    public virtual void OnCollision(Collider obj)
    {
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
