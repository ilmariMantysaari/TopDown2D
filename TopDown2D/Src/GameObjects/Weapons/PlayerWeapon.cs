using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.GameObjects
{
  public class PlayerWeapon : GameObject
  {
    public Vector2 barrelPosition;
    public int fireDelay;

    public PlayerWeapon()
    {
      behavior = new WeaponBehaviour(this);
      renderer = new Renderer(this)
      {
        texture = TopDown2D.weaponTexture
      };
      fireDelay = 100;
      barrelPosition = new Vector2(0, 10);
    }
  }
  
  public class WeaponBehaviour : Behavior
  {
    private int fireCounter;
    private PlayerWeapon weapon;

    public WeaponBehaviour(PlayerWeapon parent) : base(parent)
    {
      weapon = parent;
    }

    public override void Update()
    {
      fireCounter--;
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerShoot) && fireCounter <= 0)
      {
        var projectile = new Projectile();
        projectile.transform.Position = gameObject.transform.Position;
        gameObject.Scene.AddItem(projectile);
        fireCounter = weapon.fireDelay;
      }
    }
    
  }
}
