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
    public override void Load()
    {
      this.background = TopDown2D.mapTexture;
      var blue = new Player();
      blue.transform.Position = new Vector2(300, 100);
      //var red = new Enemy();
      
      //red.collider = new CircleCollider(red, red.renderer.texture.Height / 2);
      //red.origin = new Vector2(red.renderer.texture.Width / 2, red.renderer.texture.Height / 2);
      /*
      var red = new Enemy();

      for (int i = 0; i < 100; i++)
      {
        var enemy = new Enemy()
        {
          position = new Vector2(i * 150, 200)
        };
        this.AddItem(enemy);
      }

      for (int i = 0; i < 100; i++)
      {
        var enemy = new Enemy()
        {
          position = new Vector2(i * 150, 500)
        };
        this.AddItem(enemy);
      }
      for (int i = 0; i < 100; i++)
      {
        var enemy = new Enemy()
        {
          position = new Vector2(i * 150, 800)
        };
        this.AddItem(enemy);
      }
      this.AddItem(blue);
      //this.AddItem(red);
*/
      this.AddItem(blue);
      //this.AddItem(red);
      
      this.camera.follow = blue;
    }
  }
}
