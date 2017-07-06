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
      blue.transform.Position = new Vector2(300, 100);
      var red = new GameObject();
      red.transform = new Transform(red)
      {
        Position = new Vector2(300, 228)
      };
      red.renderer = new Renderer(red)
      {
        texture = TopDown2D.enemyTexture
      };

      var weapon = new Weapon();
      weapon.transform.Position = new Vector2(50,50);
      blue.AddChild(weapon);

      red.behavior = new Behavior(red);
      red.collider = new CircleCollider(red, red.renderer.texture.Height / 2);
      red.origin = new Vector2(red.renderer.texture.Width / 2, red.renderer.texture.Height / 2);
      this.AddItem(blue);
      this.AddItem(red);
      this.AddItem(weapon);
      this.camera.follow = blue;
    }
  }
}
