﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;

namespace TopDown2D
{
  /// <summary>
  /// 
  /// </summary>
  public class Scene
  {
    protected List<Collider> colliders;

    protected List<Renderer> graphics;

    protected List<GameObject> gameObjects;

    protected List<Behavior> behaviors;

    protected Texture2D background;

    public Camera camera;

    public Scene()
    {
      graphics = new List<Renderer>();
      colliders = new List<Collider>();
      gameObjects = new List<GameObject>();
      behaviors = new List<Behavior>();
      camera = new Camera();
    }

    public void Update()
    {
      foreach (var behavior in behaviors)
      {
        behavior.Update();
      }
      CollisionDetector.DetectCollisions(colliders);
      //Debug.WriteLine("Clear");
      camera.Update();
    }

    public void Draw(SpriteBatch batch)
    {
      batch.Begin(transformMatrix: camera.Transform, samplerState: SamplerState.PointClamp);
      batch.Draw(background, Vector2.Zero, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
      foreach (var grp in graphics)
      {
        grp.Draw(batch);
      }
      batch.End();
    }

    //Adds the object to colliders, textures etc
    public void AddItem(GameObject obj)
    {
      if (obj.collider != null)
      {
        colliders.Add(obj.collider);
      }
      if (obj.renderer != null)
      {
        graphics.Add(obj.renderer);
      }
      if (obj.behavior != null)
      {
        behaviors.Add(obj.behavior);
      }
      gameObjects.Add(obj);
      obj.scene = this;
    }
  }
}
