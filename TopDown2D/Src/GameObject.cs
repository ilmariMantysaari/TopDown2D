using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
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

    public Vector2 position;

    public GameObject()
    {
     
    }
    /*
    public Vector2 Origin()
    {
      Vector2 origin = new Vector2(texture.Width / 2f * parent.scale, texture.Height / 2f * parent.scale);
    }*/

  }
}
