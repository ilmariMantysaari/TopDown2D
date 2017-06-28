using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Textures
{
  public class Graphic
  {

    public GameObject parent;
    public Texture2D texture;

    public Graphic(GameObject parent)
    {
      this.parent = parent;
    }

    public void Draw(SpriteBatch batch)
    {
      Vector2 origin = new Vector2(texture.Width / 2f, texture.Height / 2f);
      batch.Draw(texture, parent.position, null, Color.White, 0f, origin, 1f, SpriteEffects.None, 0f);
      Debug.WriteLine(origin);
    }
  }
}
