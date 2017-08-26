using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D
{
  public class Camera
  {
    public float Zoom { get; set; }
    public Vector2 Position { get; set; }
    public Rectangle Bounds { get; set; }
    public Matrix Transform { get; protected set; }
    public Single Rotation { get; protected set; }
    public Vector2 Center { get; protected set; }

    public bool debugCamera;
    public GameObject follow;

    public Camera()
    {
      Bounds = TopDown2D.viewport.Bounds;
      Rotation = 0f;
      Zoom = 0.75f;
      Position = Vector2.Zero;
      Center = new Vector2(Bounds.Width / 2, Bounds.Height / 2);
    }

    public void Update()
    {
      UpdateMatrix();
      
      //Toggle debug camera
      //TODO: this is bad because the key can be down for multiple loop cycles, which toggles it multiple times per press
      if (Keyboard.GetState().IsKeyDown(Keys.P))
      {
        debugCamera = !debugCamera;
      }

      if (debugCamera)
      {
        DebugCamera();
      }else if (follow != null)
      {
        this.Position = follow.transform.Position;
      }
    }
    
    public void Rotate(float rotation)
    {
      this.Rotation += rotation;
      this.Rotation %= (2 * (float)Math.PI);
    }

    private void UpdateMatrix()
    {
      var origin = new Vector2(Bounds.Width / 2, Bounds.Height / 2);
      this.Transform = Matrix.CreateTranslation(new Vector3(-Position, 0.0f)) *
          //Matrix.CreateTranslation(new Vector3(-origin, 0.0f)) *
          Matrix.CreateRotationZ(Rotation) *
          Matrix.CreateScale(Zoom, Zoom, 1) * Matrix.CreateTranslation(new Vector3(origin, 0.0f));
    }

    private void DebugCamera()
    {
      Vector2 movement = Vector2.Zero;
      int moveSpeed = 10;
      //TODO: These are just for debugging
      if (Keyboard.GetState().IsKeyDown(Keys.Up))
      {
        movement.X = Transform.Up.X * moveSpeed;
        movement.Y = Transform.Up.Y * -moveSpeed;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.Down))
      {
        movement.X = Transform.Down.X * moveSpeed;
        movement.Y = Transform.Down.Y * -moveSpeed;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.Right))
      {
        movement.X = Transform.Right.X * moveSpeed;
        movement.Y = Transform.Right.Y * -moveSpeed;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.Left))
      {
        movement.X = Transform.Left.X * moveSpeed;
        movement.Y = Transform.Left.Y * -moveSpeed;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.NumPad1))
      {
        Zoom += 0.02f;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.NumPad2))
      {
        Zoom -= 0.02f;
        if (Zoom <= 0)
        {
          Zoom = 0;
        }
      }

      Vector2 newPosition = Position + movement;
      Position = newPosition;
    }
  }
}
