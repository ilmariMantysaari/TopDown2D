using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;

namespace TopDown2D.GameObjects
{
  public class Enemy : GameObject
  {
<<<<<<< HEAD
    public Enemy()
    {
      position = new Vector2(300, 228);
      graphic = new Textures.Graphic(this)
      {
        texture = TopDown2D.enemyTexture
      };
      collider = new CircleCollider(this, graphic.texture.Height / 2);
      origin = new Vector2(graphic.texture.Width / 2, graphic.texture.Height / 2);
=======
    public Enemy(Scene scene):base(scene)
    {
      this.behavior = new EnemyBehavior(this);
      this.transform = new Transform(this)
      {
        Position = new Vector2(300, 228)
      };
      this.renderer = new Renderer(this)
      {
        texture = TopDown2D.enemyTexture
      };

    }
  }

  public class EnemyBehavior : Behavior
  {
    public EnemyBehavior(GameObject parent) : base(parent)
    {
    }

    public override void Update()
    {

>>>>>>> b4cb74bde18b09499d7fc3c747c47050c1fd8127
    }
  }
}
