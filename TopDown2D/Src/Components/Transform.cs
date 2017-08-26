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
    public Vector2 origin;
    
    
    private Vector2 position;
    public Vector2 Position
    {
      get
      {
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
    public float Rotation
    {
      get
      {
        if (this.gameObject.parent != null)
        {
          return gameObject.parent.transform.rotation;
        }
        return rotation;
      }
      set
      {
        rotation = value;
      }
    }

    public GameObject gameObject;
    
    public Transform(GameObject parent)
    {
      this.gameObject = parent;
      this.rotation = 0f;
    }
  }
}
