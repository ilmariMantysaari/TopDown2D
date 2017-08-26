using Microsoft.Xna.Framework;
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
  public abstract class Scene
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

    public abstract void Load();
    
    public void Update()
    {
      for (int i = 0; i < behaviors.Count; i++)
      {
        behaviors.ElementAt(i).Update();
      }

      CollisionDetector.DetectCollisions(colliders);
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
      obj.Scene = this;
    }

    public void RemoveItem(GameObject obj)
    {
      if (obj.collider != null)
      {
        colliders.Remove(obj.collider);
      }
      if (obj.renderer != null)
      {
        graphics.Remove(obj.renderer);
      }
      if (obj.behavior != null)
      {
        behaviors.Remove(obj.behavior);
      }
      gameObjects.Remove(obj);
    }
  }
}
