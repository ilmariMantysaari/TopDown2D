﻿
namespace TopDown2D
{
  /// <summary>
  /// Handles the behaviour of the gameobject, for example movement, controls etc
  /// </summary>
  public class Behavior
  {
    public GameObject parent;

    public Behavior(GameObject parent)
    {
      this.parent = parent;
    }

    public virtual void Update()
    {

    }
  }
}
