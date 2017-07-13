﻿using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.GameObjects
{
  public class Weapon : GameObject
  {
    public int fireDelay;
    public Weapon()
    {
      behavior = new WeaponBehaviour(this);
      renderer = new Renderer(this)
      {
        texture = TopDown2D.weaponTexture
      };
      fireDelay = 100;
    }
  }

  public class WeaponBehaviour : Behavior
  {
    private int fireCounter;
    private Weapon weapon;

    public WeaponBehaviour(Weapon parent) : base(parent)
    {
      weapon = parent;
    }

    public override void Update()
    {
      fireCounter--;
      if (Keyboard.GetState().IsKeyDown(InputConfig.playerShoot) && fireCounter <= 0)
      {
        Debug.WriteLine("Shoot");
        fireCounter = weapon.fireDelay;
      }
    }
  }
}
