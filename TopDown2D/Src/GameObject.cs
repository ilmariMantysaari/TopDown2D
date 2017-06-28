using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D
{
  public class GameObject
  {
    public Collider collider;

    public Texture2D texture;

    public Vector2 position;

    public virtual void OnCollision(GameObject other)
    {

    }

  }
}
