using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Scenes
{
  public class Level1 : Scene
  {
    public Level1()
    {
      this.background = TopDown2D.mapTexture;
      var blue = new GameObject()
      {
        position = new Vector2(300, 100)
      };
      blue.graphic = new Textures.Graphic(blue)
      {
        texture = TopDown2D.playerTexture
      };
      var red = new GameObject()
      {
        position = new Vector2(300, 228)
      };
      red.graphic = new Textures.Graphic(red)
      {
        texture = TopDown2D.enemyTexture
      };
      this.AddItem(blue);
      this.AddItem(red);
    }
  }
}
