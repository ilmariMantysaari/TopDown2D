using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D
{
  /// <summary>
  /// Renders the gameobject on screen
  /// </summary>
  public class Renderer
  {

    public GameObject gameObject;
    public Texture2D texture;

    public Renderer(GameObject parent)
    {
      this.gameObject = parent;
    }

    public Renderer(GameObject parent, Texture2D texture)
    {
      this.gameObject = parent;
      this.texture = texture;
    }

    public void Draw(SpriteBatch batch)
    {
      batch.Draw(texture, gameObject.transform.Position, null, Color.White, gameObject.transform.Rotation, gameObject.origin, 1f, SpriteEffects.None, 0f);
    }
  }
}
