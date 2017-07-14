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
    }

    public override void Load()
    {
      this.background = TopDown2D.mapTexture;
      var blue = new Player(this);
      blue.transform.Position = new Vector2(300, 100);
      var red = new Enemy(this);
      
      red.collider = new CircleCollider(red, red.renderer.texture.Height / 2);
      red.origin = new Vector2(red.renderer.texture.Width / 2, red.renderer.texture.Height / 2);

      this.AddItem(blue);
      this.AddItem(red);
      
      this.camera.follow = blue;
    }
  }
}
