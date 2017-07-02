using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;
using TopDown2D.GameObjects;

namespace TopDown2D.Scenes
{
  public class Level1 : Scene
  {
    public Level1()
    {
      this.background = TopDown2D.mapTexture;
      var blue = new Player();

      var red = new GameObject();
      red.transform = new Transform(red)
      {
        position = new Vector2(300, 228)
      };
      red.graphic = new Textures.Graphic(red)
      {
        texture = TopDown2D.enemyTexture
      };
      red.behavior = new Behavior(red);
      red.collider = new CircleCollider(red, red.graphic.texture.Height / 2);
      red.origin = new Vector2(red.graphic.texture.Width / 2, red.graphic.texture.Height / 2);
      this.AddItem(blue);
      this.AddItem(red);
      this.camera.follow = blue;
    }
  }
}
