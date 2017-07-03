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

    public void Draw(SpriteBatch batch)
    {
      Vector2 origin = new Vector2(texture.Width / 2f, texture.Height / 2f);
      batch.Draw(texture, gameObject.transform.Position, null, Color.White, gameObject.transform.rotation, origin, 1f, SpriteEffects.None, 0f);
    }
  }
}
