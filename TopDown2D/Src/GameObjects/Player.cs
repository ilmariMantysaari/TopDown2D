using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDown2D.Collision;

namespace TopDown2D.GameObjects
{
  public class Player : GameObject
  {

    public GameObject weapon;
    
    public Player()
    {
      renderer = new Renderer(this)
      {
        texture = TopDown2D.playerTexture
      };
      collider = new CircleCollider(this, renderer.texture.Width / 2);
      origin = new Vector2(renderer.texture.Width / 2, renderer.texture.Height / 2);
      this.behavior = new PlayerBehavior(this);

      //TODO: testaa lapsiobjektia tässä
      //TODO: muista lisätä update draw ym. comnponent luokkiin
      
    }
  }

  public class PlayerBehavior : Behavior
  {
    public PlayerBehavior(GameObject parent) : base(parent)
    {
    }

    //the rotation of player, in 6 directions
    private const float north = (float)Math.PI;
    private const float northEast = -3 *( (float)Math.PI/4);
    private const float east = -(float)Math.PI / 2;
    private const float southEast = -(float)Math.PI/4;
    private const float south = 0;
    private const float southWest = (float)Math.PI/4;
    private const float west = (float)Math.PI / 2;
    private const float northWest = 3 * ((float)Math.PI / 4);

    public override void Update()
    {
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerUp))
      {
        gameObject.transform.Rotation = north;
        gameObject.transform.Position += new Vector2(0, -10);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerDown))
      {
        gameObject.transform.Rotation = south;
        gameObject.transform.Position += new Vector2(0, 10);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerRight))
      {
        if (Keyboard.GetState().IsKeyDown(InputConfig.playerUp))
        {
          gameObject.transform.Rotation = northEast;
        }
        else if (Keyboard.GetState().IsKeyDown(InputConfig.playerDown))
        {
          gameObject.transform.Rotation = southEast;
        }
        else
        {
          gameObject.transform.Rotation = east;
        }
        gameObject.transform.Position += new Vector2(10, 0);
      }
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerLeft))
      {
        if (Keyboard.GetState().IsKeyDown(InputConfig.playerUp))
        {
          gameObject.transform.Rotation = northWest;
        }
        else if (Keyboard.GetState().IsKeyDown(InputConfig.playerDown))
        {
          gameObject.transform.Rotation = southWest;
        }
        else
        {
          gameObject.transform.Rotation = west;
        }
        gameObject.transform.Position += new Vector2(-10, 0);
      }
      
      Debug.WriteLine(gameObject.transform.Rotation);
    }
  }
}
