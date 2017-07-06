using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.GameObjects
{
  public class Weapon : GameObject
  {
    public Weapon()
    {
      behavior = new WeaponBehaviour(this);
      renderer = new Renderer(this)
      {
        texture = TopDown2D.weaponTexture
      };
    }
  }

  public class WeaponBehaviour : Behavior
  {
    public WeaponBehaviour(GameObject parent) : base(parent)
    {

    }
  }
}
