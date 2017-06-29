using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D
{
  public class InputConfig
  {
    public static Keys playerUp;
    public static Keys playerDown;
    public static Keys playerLeft;
    public static Keys playerRight;


    public static void Load()
    {
      playerUp = Keys.W;
      playerDown = Keys.S;
      playerLeft = Keys.A;
      playerRight = Keys.D;
    }
  }
}
