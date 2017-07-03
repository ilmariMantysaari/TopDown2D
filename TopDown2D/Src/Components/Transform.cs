using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D
{
  /// <summary>
  /// Holds the position related data of the gameobject
  /// </summary>
  public class Transform
  {

    private Vector2 position;
    public Vector2 Position {
      get {
        if (this.gameObject.parent != null)
        {
          return this.position + this.gameObject.parent.transform.position;
        }
        return position;
      }
      set
      {
        position = value;
      }
    }

    public float rotation;

    public GameObject gameObject;
    
    public Transform(GameObject parent)
    {
      this.gameObject = parent;
      this.rotation = 0f;
    }
  }
}
