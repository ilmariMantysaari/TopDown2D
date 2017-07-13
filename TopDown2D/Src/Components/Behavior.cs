
namespace TopDown2D
{
  /// <summary>
  /// Handles the behaviour of the gameobject, for example movement, controls etc
  /// </summary>
  public abstract class Behavior
  {
    public GameObject gameObject;

    public Behavior(GameObject parent)
    {
      this.gameObject = parent;
    }

    public abstract void Update();
  }
}
