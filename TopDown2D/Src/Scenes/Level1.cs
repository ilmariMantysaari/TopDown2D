﻿using Microsoft.Xna.Framework;
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
      this.camera.follow = blue;
    }
  }
}
