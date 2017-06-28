using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;

namespace TopDown2D
{
  /// <summary>
  /// 
  /// </summary>
  public class Scene
  {
    protected List<Collider> Colliders;

    protected List<Graphic> Graphics;

    public void Update()
    {
      CollisionDetector.DetectCollisions(Colliders);
    }

    public void Draw()
    {
      foreach (var obj in Graphics)
      {
        obj.Draw();
      }
    }

    //Adds the object to colliders, textures etc
    public void AddItem(GameObject obj)
    {
      if (obj.collider != null)
      {
        Colliders.Add(obj.Collider);
      }
      if (obj.texture != null)
      {
        Graphics.Add(obj.Graphic);
      }
    }
  }
}
